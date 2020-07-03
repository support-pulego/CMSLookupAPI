using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class MCOServicesItem
    {
        [Key]
        public int ipkServicesId { get; set; }
        public int ifkMCOServicesID { get; set; }
        public int ifkMCOID { get; set; }
        public string bActive { get; set; }
        public int ipkMCOServicesID { get; set; }
        public string sShortDescription { get; set; }
        public string sDescription { get; set; }
        public string bIsGroupHeader { get; set; }
        public string bIsSubItem { get; set; }
        public string iIsSubItemFor { get; set; }
        public string iOrder { get; set; }
    }
}
