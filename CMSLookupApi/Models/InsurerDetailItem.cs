using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class InsurerDetailItem
    {
        [Key]
        public int InsurerId { get; set; }
        [JsonPropertyName("Company Name")]
        public string? CompanyName { get; set; }
        [JsonPropertyName("Physical Address")]
        public string? PhysicalAddress { get; set; }
        [JsonPropertyName("Postal Address")]
        public string? PostalAddress { get; set; }
        [JsonPropertyName("Website")]
        public string? Website { get; set; }
        [JsonPropertyName("Telephone")]
        public string? Tel { get; set; }
        [JsonPropertyName("Fax")]
        public string? Fax { get; set; }
        [JsonPropertyName("Email")]
        public string? Email { get; set; }
        [JsonPropertyName("Company Registration Number")]
        public string? CompanyRegNo { get; set; }
        [JsonPropertyName("Trading Name")]
        public string? TradingName { get; set; }
        [JsonPropertyName("Customer Care Number")]
        public string? CustomerCareNo { get; set; }
        [JsonPropertyName("CMS Reference Number")]
        public string? CMSRefNo { get; set; }
        [JsonPropertyName("Director 1 Names")]
        public string? Director1Names { get; set; }
        [JsonPropertyName("Director 2 Names")]
        public string? Director2Names { get; set; }
        [JsonPropertyName("Administrator CEO")]
        public string? AdministratorCEO { get; set; }
        [JsonPropertyName("Managed Care CEO")]
        public string? ManagedCareCEO { get; set; }
        [JsonPropertyName("Distributor CEO")]
        public string? DistributorCEO { get; set; }
        [JsonPropertyName("Complaints Number")]
        public string? ComplaintsNo { get; set; }
        [JsonPropertyName("Complaints Email")]
        public string? ComplaintsEmail { get; set; }
        [JsonPropertyName("Fraud TipOff Number")]
        public string? FraudTipOffNo { get; set; }
        [JsonPropertyName("Fraud TipOff Email")]
        public string? FraudTipOffEmail { get; set; }


    }
}
