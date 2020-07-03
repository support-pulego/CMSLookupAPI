using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class ProvinceItem
    {
        [Key]
        public int ProvinceId { get; set; }
        public string Provice { get; set; }
    }
}
