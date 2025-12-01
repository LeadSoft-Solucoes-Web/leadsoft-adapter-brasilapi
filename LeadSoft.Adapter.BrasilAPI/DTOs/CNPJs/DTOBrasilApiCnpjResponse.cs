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
        public string Cnpj { get; set; } = string.Empty;

        /// <summary>
        /// Identificador Matriz Filal
        /// </summary>
        [DataMember]
        [JsonProperty("identificador_matriz_filial")]
        public int IdentificadorMatrizFilial { get; set; } = 0;

        /// <summary>
        /// Descrição matriz filial
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_matriz_filial")]
        public string DescricaoMatrizFilial { get; set; } = string.Empty;

        /// <summary>
        /// Razão Social
        /// </summary>
        [DataMember]
        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; } = string.Empty;

        /// <summary>
        /// Nome Fantasia
        /// </summary>
        [DataMember]
        [JsonProperty("nome_fantasia")]
        public string NomeFantasia { get; set; } = string.Empty;

        /// <summary>
        /// Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("situacao_cadastral")]
        public int SituacaoCadastral { get; set; } = 0;

        /// <summary>
        /// Descrição Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_situacao_cadastral")]
        public string DescricaoSituacaoCadastral { get; set; } = string.Empty;

        /// <summary>
        /// Data Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("data_situacao_cadastral", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataSituacaoCadastral { get; set; } = null;

        /// <summary>
        /// Motivo Situação Cadastral
        /// </summary>
        [DataMember]
        [JsonProperty("motivo_situacao_cadastral")]
        public int MotivoSituacaoCadastral { get; set; } = 0;

        /// <summary>
        /// Nome Cidade Exterior
        /// </summary>
        [DataMember]
        [JsonProperty("nome_cidade_exterior")]
        public string NomeCidadeExterior { get; set; } = string.Empty;

        /// <summary>
        /// Código Natureza Jurídica
        /// </summary>
        [DataMember]
        [JsonProperty("codigo_natureza_juridica")]
        public int CodigoNaturezaJuridica { get; set; } = 0;

        /// <summary>
        /// Data Inicio Atividade
        /// </summary>
        [DataMember]
        [JsonProperty("data_inicio_atividade", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataInicioAtividade { get; set; } = null;

        /// <summary>
        /// Cnae Fiscal
        /// </summary>
        [DataMember]
        [JsonProperty("cnae_fiscal")]
        public int CnaeFiscal { get; set; } = 0;

        /// <summary>
        /// Cnae Fiscal Descição
        /// </summary>
        [DataMember]
        [JsonProperty("cnae_fiscal_descricao")]
        public string CnaeFiscalDescricao { get; set; } = string.Empty;

        /// <summary>
        /// Descrição Tipo Logradouro
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_tipo_logradouro")]
        public string DescricaoTipoLogradouro { get; set; } = string.Empty;

        /// <summary>
        /// Logradouro
        /// </summary>
        [DataMember]
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; } = string.Empty;

        /// <summary>
        /// Numero
        /// </summary>
        [DataMember]
        [JsonProperty("numero")]
        public string Numero { get; set; } = string.Empty;

        /// <summary>
        /// Complemento
        /// </summary>
        [DataMember]
        [JsonProperty("complemento")]
        public string Complemento { get; set; } = string.Empty;

        /// <summary>
        /// Bairro Cep
        /// </summary>
        [DataMember]
        [JsonProperty("bairro")]
        public string Bairro { get; set; } = string.Empty;

        /// <summary>
        /// Cep
        /// </summary>
        [DataMember]
        [JsonProperty("cep")]
        public string Cep { get; set; } = string.Empty;

        /// <summary>
        /// UF
        /// </summary>
        [DataMember]
        [JsonProperty("uf")]
        public string Uf { get; set; } = string.Empty;

        /// <summary>
        /// Código Município
        /// </summary>
        [DataMember]
        [JsonProperty("codigo_municipio")]
        public int CodigoMunicipio { get; set; } = 0;

        /// <summary>
        /// Município
        /// </summary>
        [DataMember]
        [JsonProperty("municipio")]
        public string Municipio { get; set; } = string.Empty;

        /// <summary>
        /// DDD Telefone 1
        /// </summary>
        [DataMember]
        [JsonProperty("ddd_telefone_1")]
        public string DddTelefone1 { get; set; } = string.Empty;

        /// <summary>
        ///  DDD Telefone 2
        /// </summary>
        [DataMember]
        [JsonProperty("ddd_telefone_2")]
        public string DddTelefone2 { get; set; } = string.Empty;

        /// <summary>
        /// DDD Fax
        /// </summary>
        [DataMember]
        [JsonProperty("ddd_fax")]
        public string DddFax { get; set; } = string.Empty;

        /// <summary>
        /// Qualificação do Responsável
        /// </summary>
        [DataMember]
        [JsonProperty("qualificacao_do_responsavel")]
        public int QualificacaoDoResponsavel { get; set; } = 0;

        /// <summary>
        /// Capital Social
        /// </summary>
        [DataMember]
        [JsonProperty("capital_social")]
        public double CapitalSocial { get; set; } = 0;

        /// <summary>
        /// Porte
        /// </summary>
        [DataMember]
        [JsonProperty("porte")]
        public string Porte { get; set; } = string.Empty;

        /// <summary>
        /// Descrição Social
        /// </summary>
        [DataMember]
        [JsonProperty("descricao_porte")]
        public string DescricaoPorte { get; set; } = string.Empty;

        /// <summary>
        /// Opção Pelo Simples
        /// </summary>
        [DataMember]
        [JsonProperty("opcao_pelo_simples")]
        public bool? OpcaoPeloSimples { get; set; } = null;

        /// <summary>
        /// Data Opção Pelo Simples
        /// </summary>
        [DataMember]
        [JsonProperty("data_opcao_pelo_simples", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataOpcaoPeloSimples { get; set; } = null;

        /// <summary>
        /// Data Exclusão do Simples
        /// </summary>
        [DataMember]
        [JsonProperty("data_exclusao_do_simples", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataExclusaoDoSimples { get; set; } = null;

        /// <summary>
        /// Opção Pelo Mei
        /// </summary>
        [DataMember]
        [JsonProperty("opcao_pelo_mei")]
        public bool? OpcaoPeloMei { get; set; } = null;

        /// <summary>
        /// Situação Especial
        /// </summary>
        [DataMember]
        [JsonProperty("situacao_especial")]
        public string SituacaoEspecial { get; set; } = string.Empty;

        /// <summary>
        /// Data Situacao Especial
        /// </summary>
        [DataMember]
        [JsonProperty("data_situacao_especial", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DataSituacaoEspecial { get; set; } = null;

        /// <summary>
        /// Qsa
        /// </summary>
        [DataMember]
        [JsonProperty("qsa", NullValueHandling = NullValueHandling.Ignore)]
        public IList<DTOBrasilApiCnpjSocio>? Qsa { get; set; } = null;

        /// <summary>
        /// Cnaes Secundarias
        /// </summary>
        [DataMember]
        [JsonProperty("cnaes_secundarios")]
        public IList<DTOBrasilApiCnpjCnaeSecundario>? DtoCnaesSecundarios { get; set; } = null;
    }
}

