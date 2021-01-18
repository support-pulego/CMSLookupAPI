using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class CategoryItem
    {
        [Key]
        public int CategoryID { get; set; }
        public string Category { get; set; }

    }
}
