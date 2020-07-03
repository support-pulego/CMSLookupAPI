using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class SubCategoryItem
    {
        [Key]
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string SubCategory { get; set; }
       
    }
}
