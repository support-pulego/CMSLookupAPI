using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class InsurerFSBDetailItem
    {
        
        [JsonPropertyName("Underwriter Name")]
        public string UnderwriterName { get; set; }
        [JsonPropertyName("FSP Name")]
        public string FSPName { get; set; }
        [Key]
        [JsonPropertyName("CMS Ref No")]
        public string CMSRefNo { get; set; }
        [JsonPropertyName("FSP No")]
        public string FSPNo { get; set; }
        
    }
}
