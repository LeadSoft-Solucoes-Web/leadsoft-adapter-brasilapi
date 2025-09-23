using LeadSoft.Common.Library.Extensions;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LeadSoft.Adapter.BrasilAPI.DTOs.Banks
{
    /// <summary>
    /// DTO Brasil Api Banks Response
    /// </summary>
    [Serializable]
    [DataContract]
    public class DTOBrasilApiBankResponse
    {
        private string _name;
        private string _fullName;

        /// <summary>
        /// Ispb
        /// </summary>
        [DataMember]
        [JsonProperty("ispb")]
        public string Ispb { get; set; }

        /// <summary>
        /// Bank Name
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get => _name.ToTitleCase(); set { _name = value; } }

        /// <summary>
        /// Bank Code
        /// </summary>
        [DataMember]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// Bank Full Name
        /// </summary>
        [DataMember]
        [JsonProperty("fullName")]
        public string FullName { get => _fullName.ToTitleCase(); set { _fullName = value; } }
    }
}
