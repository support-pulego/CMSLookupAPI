﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class DistributorCEOItem
    {
        [Key]
        public int DistributorId { get; set; }
        public string Website { get; set; }
        [JsonPropertyName("Physical Address")]
        public string PhysicalAddress { get; set; }
        [JsonPropertyName("Postal Address")]
        public string PostalAddress { get; set; }
        [JsonPropertyName("Telephone")]
        public string Tel { get; set; }
        [JsonPropertyName("Fax")]
        public string Fax { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("CEO")]
        public string CEO { get; set; }
        [JsonPropertyName("Company Registration Number")]
        public string CompanyRegNo { get; set; }
        public string FSPNo { get; set; }
    }
}