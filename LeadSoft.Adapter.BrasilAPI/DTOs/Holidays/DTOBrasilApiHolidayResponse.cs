using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LeadSoft.Adapter.BrasilAPI.DTOs.Holidays
{
    /// <summary>
    /// Brasil Api Holiday Response
    /// </summary>
    [Serializable]
    [DataContract]
    public class DTOBrasilApiHolidayResponse
    {
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Holyday Tyoe
        /// </summary>
        [DataMember]
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
