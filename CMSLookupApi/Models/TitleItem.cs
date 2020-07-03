using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class TitleItem
    {
       [Key]
       public int  ContactTitleId {get; set;}
       public string ContactTitleName { get; set; }
    }
}
