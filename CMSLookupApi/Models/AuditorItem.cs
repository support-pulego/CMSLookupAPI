using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class AuditorItem
    {
        [Key]
        public string AuditorFirmName { get; set; }
        public string AuthorisationType { get; set; }
        public string AuthorisationNumber { get; set; }
        public DateTime? AuthorisationDate { get; set; }
        public DateTime? AuthorisationDateUtc { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? ExpiryDateUtc { get; set; }
        public string DeclarationReviewedName { get; set; }
    }
}
