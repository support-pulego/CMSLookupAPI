using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class ProductDetailItem
    {
        
        [JsonPropertyName("Company Name")]
        public string CompanyName { get; set; }
        [JsonPropertyName("Product ID")]
        public int ProductID { get; set; }
        [Key]
        [JsonPropertyName("Product")]
        public string Product { get; set; }
        [JsonPropertyName("Exemption Period Start")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime ExemptionPeriodStart { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonPropertyName("Exemption Period End")]
        public DateTime ExemptionPeriodEnd { get; set; }
        [JsonPropertyName("Exemption")]
        public string Exemption { get; set; }
        
    }
}
