using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class MCOServicesDetailItem
    {
        [Key]
        public int ConditionID { get; set; }
        public int ifkMCOCondID { get; set; }
        [JsonPropertyName("Short Description")]
        public string sShortDesc { get; set; }
        [JsonPropertyName("Description")]
        public string @true { get; set; }
        public string sDescription { get; set; }
        public bool bIsGroupHeader { get; set; }
        public bool bIsSubItem { get; set; }
        public int? bIsSubItemFor { get; set; }
        public int iConditionPeriod { get; set; }
    }
}
