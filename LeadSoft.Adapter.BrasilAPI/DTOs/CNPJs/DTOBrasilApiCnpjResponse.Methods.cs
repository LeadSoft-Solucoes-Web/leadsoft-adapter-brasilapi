namespace LeadSoft.Adapter.BrasilAPI.DTOs.CNPJs
{
    /// <summary>
    /// DTO Brasil Api Cnpj Response - Methods
    /// </summary>
    public partial class DTOBrasilApiCnpjResponse
    {
        public ISet<DTOBrasilApiCnpjCnaeSecundario> ObterCnaesContidos(params int[] cnaes)
        {
            ISet<DTOBrasilApiCnpjCnaeSecundario> dtoCnaes = new HashSet<DTOBrasilApiCnpjCnaeSecundario>();

            if (cnaes.Length == 0)
            {
                dtoCnaes = this.DtoCnaesSecundarios?.ToHashSet() ?? [];
                dtoCnaes.Add(new DTOBrasilApiCnpjCnaeSecundario(CnaeFiscal, CnaeFiscalDescricao));
            }

            ISet<int> cnaesInCompany = this.DtoCnaesSecundarios?.Select(c => c.Codigo).ToHashSet() ?? [];
            cnaesInCompany.Add(this.CnaeFiscal);
            ISet<int> cnaesToCheck = cnaes.ToHashSet();

            foreach (int cnae in cnaesInCompany.Intersect(cnaesToCheck))
                if (cnae == this.CnaeFiscal)
                    dtoCnaes.Add(new DTOBrasilApiCnpjCnaeSecundario(this.CnaeFiscal, this.CnaeFiscalDescricao));
                else if (this.DtoCnaesSecundarios is not null && this.DtoCnaesSecundarios.Any(c => c.Codigo == cnae))
                    dtoCnaes.Add(this.DtoCnaesSecundarios?.Single(c => c.Codigo == cnae));

            return dtoCnaes;
        }

        public bool ContemCnae(params int[] cnaes)
        {
            ISet<int> cnaesInCompany = this.DtoCnaesSecundarios?.Select(c => c.Codigo).ToHashSet() ?? [];
            cnaesInCompany.Add(this.CnaeFiscal);
            ISet<int> cnaesToCheck = cnaes.ToHashSet();

            return cnaesInCompany.Overlaps(cnaesToCheck);
        }
    }
}

