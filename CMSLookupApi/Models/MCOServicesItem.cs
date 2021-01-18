using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class MCOServicesItem
    {
        [Key]
        public int ipkServicesId { get; set; }
        public int ipkMCOServicesID { get; set; }
        [JsonPropertyName("Short Description")]
        public string sShortDescription { get; set; }
        [JsonPropertyName("Description")]
        public string sDescription { get; set; }
        public bool bIsGroupHeader { get; set; }
        public bool bIsSubItem { get; set; }
        public int? iIsSubItemFor { get; set; }
        public bool bActive { get; set; }
        public int? iOrder { get; set; }
    }
}
