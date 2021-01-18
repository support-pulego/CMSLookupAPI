using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class InsurersItem
    {
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("Insurer")]
        public string Insurer { get; set; }
        [JsonPropertyName("CMS Reference Number")]
        public string CMSRefNo { get; set; }
        [JsonPropertyName("Underwriter Name")]
        public string? Underwriter { get; set; }
        public int? CEOId { get; set; }
        [JsonPropertyName("Insurer CEO")]
        public string? InsurerCEOName { get; set; }
        [JsonPropertyName("Underwriter CEO")]
        public string? UnderwriterCEOName { get; set; }
        [JsonPropertyName("Director 1 Names")]
        public string? Director1Names { get; set; }
        [JsonPropertyName("Director 2 Names")]
        public string? Director2Names { get; set; }
        public int? Director1Id { get; set; }
        public int? Director2Id { get; set; }
        public int? UnderwriterId { get; set; }
        [JsonPropertyName("Complaints No.")]
        public string? ComplaintsNo { get; set; }
        [JsonPropertyName("Customer Care No.")]
        public string? CustomerCareNo { get; set; }
        [JsonPropertyName("Fraud TipOff Number")]
        public string? FraudTipOffNo { get; set; }
        [JsonPropertyName("Exemption Period Start")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime ExemptionPeriodStart { get; set; }
        [JsonPropertyName("Exemption Period End")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime ExemptionPeriodEnd { get; set; }
        [JsonPropertyName("IsUnderwriter")]
        public bool IsUnderwriter { get; set; }


    }
}
