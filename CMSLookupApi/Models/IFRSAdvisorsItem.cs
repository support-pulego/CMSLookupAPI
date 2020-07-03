using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class IFRSAdvisorsItem
    {
        [Key]
        public string IFRSAdvisorID { get; set; }
        public string EntityName { get; set; }
        public string ExternalIFRSAdvisor { get; set; }
        public string AuthorisationNumber {get; set;}
        public DateTime AuthorisationStartDate { get; set; }
        public DateTime AuthorisationExpiryDate { get; set; }
    }
}
