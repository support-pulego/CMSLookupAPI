using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class AccreditedMedicalBrokeragesItem
    {
        [Key]
        public Guid Isp_BrokerageId { get; set; }
        [JsonPropertyName("ISP Name")]
        public string Isp_name { get; set; }
        public int Bmu_BrokerageId { get; set; }
        [JsonPropertyName("ISP Accreditation Date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Isp_AccreditationDate { get; set; }
        [JsonPropertyName("ISP Accreditation Expiry")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Isp_AccreditationExpiry { get; set; }
        [JsonPropertyName("ISP Accreditation Number")]
        public string Isp_AccreditationNumber { get; set; }
        [JsonPropertyName("ISP Call Centre Number")]
        public string Isp_CallCentreNumber { get; set; }
        [JsonPropertyName("ISP Fax Number")]
        public string Isp_FaxNumber { get; set; }
        [JsonPropertyName("ISP Status Reason")]
        public string Isp_StatusReason { get; set; }
        [JsonPropertyName("ISP Tele[hone Number")]
        public string Isp_TelephoneNumber { get; set; }
        [JsonPropertyName("ISP Website URL")]
        public string Isp_WebsiteURL { get; set; }
        public string Isp_PersonId { get; set; }
        public string Isp_physicaladdressid { get; set; }
        public string Isp_postaladdressid { get; set; }
        [JsonPropertyName("ISP Address 1 Street 1")]
        public string Isp_Address1Street1 { get; set; }
        [JsonPropertyName("ISP Address 1 Street 2")]
        public string Isp_Address1Street2 { get; set; }
        [JsonPropertyName("ISP Address 1 Street 3")]
        public string Isp_Address1Street3 { get; set; }
        [JsonPropertyName("ISP Address 1 City")]
        public string Isp_Address1City { get; set; }
        [JsonPropertyName("ISP Address 2 Street 1")]
        public string Isp_Address2Street1 { get; set; }
        [JsonPropertyName("ISP Address 2 Street 2")]
        public string Isp_Address2Street2 { get; set; }
        [JsonPropertyName("ISP Address 2 Street 3")]
        public string Isp_Address2Street3 { get; set; }
        [JsonPropertyName("ISP Address 1 Province")]
        public string Isp_Address1Province { get; set; }
        [JsonPropertyName("ISP Address 2")]
        public string Isp_Address2 { get; set; }
        [JsonPropertyName("ISP Address 2 City")]
        public string Isp_Address2City { get; set; }
        [JsonPropertyName("ISP Address 1 ZIP Postal Code")]
        public string Isp_Address1ZIPPostalCode { get; set; }
        [JsonPropertyName("ISP Address 2 ZIP Postal Code")]
        public string Isp_Address2ZIPPostalCode { get; set; }
    }
}
