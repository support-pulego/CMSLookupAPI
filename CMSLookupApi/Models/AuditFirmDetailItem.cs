using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class AuditFirmDetailItem
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
        [JsonPropertyName("Address 1 City")]
        public string Address1City { get; set; }
        [JsonPropertyName("Address 1 Province")]
        public int Address1Province { get; set; }
        [JsonPropertyName("Address 1 Province Name")]
        public string Address1ProvinceName { get; set; }
        [JsonPropertyName("Address 1 Street 1")]
        public string Address1Street1 { get; set; }
        [JsonPropertyName("Address 1 Street 2")]
        public string Address1Street2 { get; set; }
        [JsonPropertyName("Address 1 Street 3")]
        public string Address1Street3 { get; set; }
        [JsonPropertyName("Address 1 Zip Postal Code")]
        public string Address1ZipPostalCode { get; set; }
        [JsonPropertyName("Address 2 City")]
        public string Address2City { get; set; }
        [JsonPropertyName("Address 2 Province")]
        public int Address2Province { get; set; }
        [JsonPropertyName("Address 2 Province Name")]
        public string Address2ProvinceName { get; set; }
        [JsonPropertyName("Address 2 Street 1")]
        public string Address2Street1 { get; set; }
        [JsonPropertyName("Address 2 Street 2")]
        public string Address2Street2 { get; set; }
        [JsonPropertyName("Address 2 Street 3")]
        public string Address2Street3 { get; set; }
        [JsonPropertyName("Address 2 Zip Postal Code")]
        public string Address2ZipPostalCode { get; set; }
        [JsonPropertyName("Authorisation Status")]
        public string AuthorisationStatus { get; set; }
        [JsonPropertyName("Vat Registration Number")]
        public string VatRegistrationNumber { get; set; }
        [JsonPropertyName("Fax")]
        public string Fax { get; set; }
        [JsonPropertyName("Email Address")]
        public string EmailAddress { get; set; }
        [JsonPropertyName("Telephone")]
        public string Telephone { get; set; }
        [JsonPropertyName("Website")]
        public string Website { get; set; }

    }
}
