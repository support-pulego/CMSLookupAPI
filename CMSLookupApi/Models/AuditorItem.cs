using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class AuditorItem
    {
        [Key]
        [JsonPropertyName("Auditor Firm Name")]
        public string AuditorFirmName { get; set; }
        [JsonPropertyName("Authorisation Type")]
        public string AuthorisationType { get; set; }
        [JsonPropertyName("Authorisation Number")]
        public string AuthorisationNumber { get; set; }
        [JsonPropertyName("Authorisation Date")]
        public DateTime? AuthorisationDate { get; set; }
        [JsonPropertyName("Authorisation Date Utc")]
        public DateTime? AuthorisationDateUtc { get; set; }
        [JsonPropertyName("Expiry Date")]
        public DateTime? ExpiryDate { get; set; }
        [JsonPropertyName("Expiry Date Utc")]
        public DateTime? ExpiryDateUtc { get; set; }
        [JsonPropertyName("Declaration Reviewed Name")]
        public string DeclarationReviewedName { get; set; }
    }
}
