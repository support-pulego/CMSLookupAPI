using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class AuditFirmConditionsItem
    {
        [Key]
        public Guid AuditFirmID { get; set; }
        [JsonPropertyName("Audit Firm")]
        public string AuditFirm { get; set; }
        public Guid ConditionID { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}
