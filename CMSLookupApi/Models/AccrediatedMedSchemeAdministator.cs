using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class AccrediatedMedSchemeAdministatorItem
    {
        public string AdminID { get; set; }
        public string OrgName { get; set; }
        public string OrgActivateDate { get; set; }
        public string OrgExpiry { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public int LinkId { get; set; }
        public string WebAddress { get; set; }

    }
}
