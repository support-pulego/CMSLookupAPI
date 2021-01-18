using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class AuditFirmItem
    {
        [Key]
        public Guid AuditFirmID { get; set; }
        [JsonPropertyName("Audit Firm")]
        public string AuditFirm { get; set; }
        [JsonPropertyName("Authorisation Number")]
        public string AuthorisationNumber { get; set; }
        [JsonPropertyName("Start Date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime StartDate { get; set; }
        [JsonPropertyName("Expiry Date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Expirydate { get; set; }
    }
}
