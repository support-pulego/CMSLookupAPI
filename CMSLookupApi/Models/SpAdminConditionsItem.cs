using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class SpAdminConditionsItem
    {
        [Key]
        [JsonPropertyName("Condition Number")]
        public string sConditionNo { get; set; }
        public string ParentID { get; set; }
        [JsonPropertyName("Description Address")]
        public string sDescription { get; set; }
        public int Version { get; set; }
    }
}
