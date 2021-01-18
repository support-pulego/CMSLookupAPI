using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class MedschemeDetailItem
    {
        [Key]
        [JsonPropertyName("Full Name")]
        public string Fullname { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Telephone")]
        public string Telephone { get; set; }
        [JsonPropertyName("Fax")]
        public string Fax { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("Province")]
        public string Province { get; set; }
        [JsonPropertyName("Postal Address")]
        public string PostalFull { get; set; }

    }
}