using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class InsurerCEOItem
    {
        [Key]
        public int CEOId { get; set; }
        [JsonPropertyName("Title Of Courtesy")]
        public string TitleOfCourtesy { get; set; }
        [JsonPropertyName("Full Names")]
        public string FullNames { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("Company Name")]
        public string CompanyName { get; set; }
        [JsonPropertyName("Physical Address")]
        public string PhysicalAddress { get; set; }
        [JsonPropertyName("Postal Address")]
        public string PostalAddress { get; set; }
        [JsonPropertyName("Telephone")]
        public string Tel { get; set; }
        [JsonPropertyName("Fax")]
        public string Fax { get; set; }
        [JsonPropertyName("Insurer Email")]
        public string InsurerEmail { get; set; }
        [JsonPropertyName("Company Registration Number")]
        public string CompanyRegNo { get; set; }
        public string FSPNo { get; set; }
        [JsonPropertyName("Trading Name")]
        public string TradingName { get; set; }
    }
}
