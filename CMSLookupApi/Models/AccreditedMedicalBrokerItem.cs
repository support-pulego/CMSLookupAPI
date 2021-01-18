using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class AccreditedMedicalBrokerItem
    {
        [Key]
        public Guid Isp_BrokerId { get; set; }
        [JsonPropertyName("ISP Name")]
        public string Isp_name { get; set; }
        [JsonPropertyName("ISP Accreditation Date")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Isp_AccreditationDate { get; set; }
        [JsonPropertyName("ISP Accreditation Expiry")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Isp_AccreditationExpiry { get; set; }
        [JsonPropertyName("ISP Accreditation Number")]
        public string Isp_AccreditationNumber { get; set; }
        [JsonPropertyName("ISP Broker Type")]
        public int Isp_BrokerType { get; set; }
        public Guid Isp_BrokerageId { get; set; }
        public Guid Isp_PersonId { get; set; }
        public int Cms_bmu_BrokerId { get; set; }
    }
}
