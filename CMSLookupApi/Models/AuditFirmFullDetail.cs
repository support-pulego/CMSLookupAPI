using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class AuditFirmFullDetail
    {
       
        public Guid AuditFirmID { get; set; }
        public string AuditFirm { get; set; }
        public string AuthorisationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Expirydate { get; set; }
        public string Address1City { get; set; }
        public int Address1Province { get; set; }
        public string Address1ProvinceName { get; set; }
        public string Address1Street1 { get; set; }
        public string Address1Street2 { get; set; }
        public string Address1Street3 { get; set; }
        public string Address1ZipPostalCode { get; set; }
        public string Address2City { get; set; }
        public int Address2Province { get; set; }
        public string Address2ProvinceName { get; set; }
        public string Address2Street1 { get; set; }
        public string Address2Street2 { get; set; }
        public string Address2Street3 { get; set; }
        public string Address2ZipPostalCode { get; set; }
        public string AuthorisationStatus { get; set; }
        public string VatRegistrationNumber { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public string Website { get; set; }
        public Guid ConditionID { get; set; }
        public string Description { get; set; }
    }
}
