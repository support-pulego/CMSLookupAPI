using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class EntityListItem
    {
        [Key]
        public string PrimaryNo { get; set; }
        public int EntityTypeID { get; set; }
        public string EntityName {get; set;}
         
    }
}
