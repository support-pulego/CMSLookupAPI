using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class ComplaintCategoryAgainstItem
    {
        [Key]
        public int EntityTypeID { get; set; }
        public string EntityTypeDesc { get; set; }
    }
}
