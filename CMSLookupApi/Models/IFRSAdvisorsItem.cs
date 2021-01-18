using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class IFRSAdvisorsItem
    {
        [Key]
        public Guid IFRSAdvisorID { get; set; }
        [JsonPropertyName("Entity Name")]
        public string EntityName { get; set; }
        [JsonPropertyName("External IFRS Advisor")]
        public string ExternalIFRSAdvisor { get; set; }
        [JsonPropertyName("Authorisation Number")]
        public string AuthorisationNumber { get; set; }
        [JsonPropertyName("Authorisation Start Date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime AuthorisationStartDate { get; set; }
        [JsonPropertyName("Authorisation Expiry Date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime AuthorisationExpiryDate { get; set; }
    }
}
