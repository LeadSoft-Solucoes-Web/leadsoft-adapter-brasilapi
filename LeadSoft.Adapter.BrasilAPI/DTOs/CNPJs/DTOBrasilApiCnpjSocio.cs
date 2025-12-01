using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LeadSoft.Adapter.BrasilAPI.DTOs.CNPJs
{
    /// <summary>
    /// DTO Brasil Api Cnpj Socio
    /// </summary>

    [Serializable]
    [DataContract]
    public partial class DTOBrasilApiCnpjSocio
    {
        /// <summary>
        /// CNPJ
        /// </summary>
        [DataMember]
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; } = string.Empty;

        /// <summary>
        /// Identificador de Socio
        /// </summary>
        [DataMember]
        [JsonProperty("identificador_de_socio")]
        public int IdentificadorDeSocio { get; set; } = 0;

        /// <summary>
        /// Nome Socio
        /// </summary>
        [DataMember]
        [JsonProperty("nome_socio")]
        public string NomeSocio { get; set; } = string.Empty;

        /// <summary>
        /// CNPJ/CPF Do Socio
        /// </summary>
        [DataMember]
        [JsonProperty("cnpj_cpf_do_socio")]
        public string CnpjCpfDoSocio { get; set; } = string.Empty;

        /// <summary>
        /// Código de Qualificação Sócio
        /// </summary>
        [DataMember]
        [JsonProperty("codigo_qualificacao_socio")]
        public int CodigoQualificacaoSocio { get; set; } = 0;

        /// <summary>
        /// Percentual Capital Social
        /// </summary>
        [DataMember]
        [JsonProperty("percentual_capital_social")]
        public int PercentualCapitalSocial { get; set; } = 0;

        /// <summary>
        /// Data Entrada Sociedade
        /// </summary>
        [DataMember]
        [JsonProperty("data_entrada_sociedade")]
        public string DataEntradaSociedade { get; set; } = string.Empty;

        /// <summary>
        /// Cpf Representante Legal
        /// </summary>
        [DataMember]
        [JsonProperty("cpf_representante_legal")]
        public string CpfRepresentanteLegal { get; set; } = string.Empty;

        /// <summary>
        /// Nome Representante Legal
        /// </summary>
        [DataMember]
        [JsonProperty("nome_representante_legal")]
        public string NomeRepresentanteLegal { get; set; } = string.Empty;

        /// <summary>
        /// Código Qualificação Representante Legal
        /// </summary>
        [DataMember]
        [JsonProperty("codigo_qualificacao_representante_legal")]
        public int CodigoQualificacaoRepresentanteLegal { get; set; } = 0;

    }
}

