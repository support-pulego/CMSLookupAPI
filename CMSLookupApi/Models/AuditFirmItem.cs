using System;
using System.ComponentModel.DataAnnotations;

namespace CMSLookupApi.Models
{
    public class AuditFirmItem
    {
        [Key]
        public Guid AuditFirmID { get; set; }
        public string AuditFirm { get; set; }
        public string AuthorisationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Expirydate { get; set; }
    }
}
