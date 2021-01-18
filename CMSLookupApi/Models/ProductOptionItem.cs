using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Models
{
    public class ProductOptionItem
    {
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        [JsonPropertyName("Active")]
        public bool Active { get; set; }
        [JsonPropertyName("Product Id")]
        public int ProductId { get; set; }
        
    }
}
