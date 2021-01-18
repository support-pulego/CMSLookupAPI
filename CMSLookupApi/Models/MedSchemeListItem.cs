using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class MedschemeListItem
    {
        [Key]
        [JsonPropertyName("Scheme Name")]
        public string SchemeName { get; set; }
        [JsonPropertyName("Scheme Type")]
        public string SchemeType { get; set; }
        [JsonPropertyName("Telephone")]
        public string Telephone { get; set; }
        [JsonPropertyName("Registration Date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime RegistrationDate { get; set; }
        

    }
}
