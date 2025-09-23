using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LeadSoft.Adapter.BrasilAPI.DTOs.CNPJs
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class DTOBrasilApiCnpjCnaeSecundario
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [JsonProperty("codigo")]
        public int Codigo { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [JsonProperty("descricao")]
        public string Descricao { get; set; } = string.Empty;
    }
}

