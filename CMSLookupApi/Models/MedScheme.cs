using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class MedschemeItem
    {
        [Key]
        public string SchemeName { get; set; }
        public string SchemeType { get; set; }
        public string Telephone { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
