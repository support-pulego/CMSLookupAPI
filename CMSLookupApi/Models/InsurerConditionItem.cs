using CMSLookupApi.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class InsurerConditionItem
    {
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("Condition No")]
        public string ConditionNo { get; set; }
        [JsonPropertyName("Condition Description")]
        public string ConditionDescription { get; set; }
        [JsonPropertyName("Due Date Start")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime DueDateStart { get; set; }
        [JsonPropertyName("Info No")]
        public string InfoNo { get; set; }
        [JsonPropertyName("Info Description")]
        public string InfoDescription { get; set; }
        [JsonPropertyName("Requirement No")]
        public string RequirementNo { get; set; }
        [JsonPropertyName("Requirement Description")]
        public string RequirementDescription { get; set; }
        [JsonPropertyName("Company Name")]
        public string CompanyName { get; set; }
    }
}
