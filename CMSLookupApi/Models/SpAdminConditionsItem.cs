using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class SpAdminConditionsItem
    {
        [Key]
        public string sConditionNo { get; set; }
        public string ParentID { get; set;}
        public string sDescription { get; set; }
        public int Version	{get; set;}
    }
}
