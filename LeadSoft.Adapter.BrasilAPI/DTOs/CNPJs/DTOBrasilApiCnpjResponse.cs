using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LeadSoft.Adapter.BrasilAPI.DTOs.CNPJs
{
    /// <summary>
    /// DTO Brasil Api Cnpj Response
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class DTOBrasilApiCnpjResponse
    {
        /// <summary>
        /// Cnpj
        /// </summary>
        [DataMember]
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        /// <summary>
        /// Identificador Matriz Filal
        /// </summary>
        [DataMember]
        [JsonProperty("identificador_matriz_filial")]
        public int IdentificadorMatrizFilial { get; set; }

        /// <summary>
        /// Descrição matriz filial
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_matriz_filial")]
        public string DescricaoMatrizFilial { get; set; }

        /// <summary>
        /// Razão Social
        /// </summary>
        [DataMember]
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }

        /// <summary>
        /// Nome Fantasia
        /// </summary>
        [DataMember]
        [JsonProperty("nome_fantasia")]
        public string NomeFantasia { get; set; }

        /// <summary>
        /// Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("situacao_cadastral")]
        public int SituacaoCadastral { get; set; }

        /// <summary>
        /// Descrição Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_situacao_cadastral")]
        public string DescricaoSituacaoCadastral { get; set; }

        /// <summary>
        /// Data Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("data_situacao_cadastral", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataSituacaoCadastral { get; set; }

        /// <summary>
        /// Motivo Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("motivo_situacao_cadastral")]
        public int MotivoSituacaoCadastral { get; set; }

        /// <summary>
        /// Nome Cidade Exterior
        /// </summary>
        [DataMember]
        [JsonProperty("nome_cidade_exterior")]
        public string NomeCidadeExterior { get; set; }

        /// <summary>
        /// Código Natureza Jurídica
        /// </summary>
        [DataMember]
        [JsonProperty("codigo_natureza_juridica")]
        public int CodigoNaturezaJuridica { get; set; }

        /// <summary>
        /// Data Inicio Atividade
        /// </summary>
        [DataMember]
        [JsonProperty("data_inicio_atividade", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataInicioAtividade { get; set; }

        /// <summary>
        /// Cnae Fiscal
        /// </summary>
        [DataMember]
        [JsonProperty("cnae_fiscal")]
        public int CnaeFiscal { get; set; }

        /// <summary>
        /// Cnae Fiscal Descição
        /// </summary>
        [DataMember]
        [JsonProperty("cnae_fiscal_descricao")]
        public string CnaeFiscalDescricao { get; set; }

        /// <summary>
        /// Descrição Tipo Logradouro
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_tipo_logradouro")]
        public string DescricaoTipoLogradouro { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        [DataMember]
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        /// <summary>
        /// Numero
        /// </summary>
        [DataMember]
        [JsonProperty("numero")]
        public string Numero { get; set; }

        /// <summary>
        /// Complemento
        /// </summary>
        [DataMember]
        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        /// <summary>
        /// Bairro Cep
        /// </summary>
        [DataMember]
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        /// <summary>
        /// Cep
        /// </summary>
        [DataMember]
        [JsonProperty("cep")]
        public string Cep { get; set; }

        /// <summary>
        /// UF
        /// </summary>
        [DataMember]
        [JsonProperty("uf")]
        public string Uf { get; set; }

        /// <summary>
        /// Código Município
        /// </summary>
        [DataMember]
        [JsonProperty("codigo_municipio")]
        public int CodigoMunicipio { get; set; }

        /// <summary>
        /// Município
        /// </summary>
        [DataMember]
        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        /// <summary>
        /// DDD Telefone 1
        /// </summary>
        [DataMember]
        [JsonProperty("ddd_telefone_1")]
        public string DddTelefone1 { get; set; }

        /// <summary>
        ///  DDD Telefone 2
        /// </summary>
        [DataMember]
        [JsonProperty("ddd_telefone_2")]
        public string DddTelefone2 { get; set; }

        /// <summary>
        /// DDD Fax
        /// </summary>
        [DataMember]
        [JsonProperty("ddd_fax")]
        public string DddFax { get; set; }

        /// <summary>
        /// Qualificação do Responsável
        /// </summary>
        [DataMember]
        [JsonProperty("qualificacao_do_responsavel")]
        public int QualificacaoDoResponsavel { get; set; }

        /// <summary>
        /// Capital Social
        /// </summary>
        [DataMember]
        [JsonProperty("capital_social")]
        public double CapitalSocial { get; set; }

        /// <summary>
        /// Porte
        /// </summary>
        [DataMember]
        [JsonProperty("porte")]
        public string Porte { get; set; }

        /// <summary>
        /// Descrição Social
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_porte")]
        public string DescricaoPorte { get; set; }

        /// <summary>
        /// Opção Pelo Simples
        /// </summary>
        [DataMember]
        [JsonProperty("opcao_pelo_simples")]
        public bool OpcaoPeloSimples { get; set; }

        /// <summary>
        /// Data Opção Pelo Simples
        /// </summary>
        [DataMember]
        [JsonProperty("data_opcao_pelo_simples", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataOpcaoPeloSimples { get; set; }

        /// <summary>
        /// Data Exclusão do Simples
        /// </summary>
        [DataMember]
        [JsonProperty("data_exclusao_do_simples", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataExclusaoDoSimples { get; set; }

        /// <summary>
        /// Opção Pelo Mei
        /// </summary>
        [DataMember]
        [JsonProperty("opcao_pelo_mei")]
        public bool OpcaoPeloMei { get; set; }

        /// <summary>
        /// Situação Especial
        /// </summary>
        [DataMember]
        [JsonProperty("situacao_especial")]
        public string SituacaoEspecial { get; set; }

        /// <summary>
        /// Data Situacao Especial
        /// </summary>
        [DataMember]
        [JsonProperty("data_situacao_especial", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataSituacaoEspecial { get; set; }

        /// <summary>
        /// Qsa
        /// </summary>
        [DataMember]
        [JsonProperty("qsa", NullValueHandling = NullValueHandling.Ignore)]
        public IList<DTOBrasilApiCnpjSocio> Qsa { get; set; }

        /// <summary>
        /// Cnaes Secundarias
        /// </summary>
        [DataMember]
        [JsonProperty("cnaes_secundarios")]
        public IList<DTOBrasilApiCnpjCnaeSecundario> DtoCnaesSecundarios { get; set; }
    }
}

