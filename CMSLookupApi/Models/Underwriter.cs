using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class UnderwriterItem
    {
        [Key]
        public string Insurer { get; set; }
        public string UnderwriterName { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string CEO { get; set; }
        public string CompanyRegNo { get; set; }
        public string FSPNo { get; set; }
        public string TradingName { get; set; }

    }
}
