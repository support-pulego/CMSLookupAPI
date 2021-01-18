using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class AccrediatedMedSchemeAdministatorItem
    {
        [Key]
        public string AdminID { get; set; }
        [JsonPropertyName("Organisation Name")]
        public string OrgName { get; set; }
        [JsonPropertyName("Organisation Activate Date")]
        public string OrgActivateDate { get; set; }
        [JsonPropertyName("Organisation Expiry")]
        public string OrgExpiry { get; set; }
        [JsonPropertyName("Contact")]
        public string Contact { get; set; }
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [JsonPropertyName("Telephone")]
        public string Tel { get; set; }
        public int LinkId { get; set; }
        [JsonPropertyName("Web Address")]
        public string WebAddress { get; set; }

    }
}
