using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class ComplaintCategoryAgainstItem
    {
        [Key]
        public int EntityTypeID { get; set; }
        public string EntityTypeDesc { get; set; }
    }
}
