using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class AuditFirmConditionsItem
    {
        [Key]
        public Guid AuditFirmID { get; set; }
        public string AuditFirm { get; set; }
        public string ConditionID { get; set; }
        public string Description { get; set; }
    }
}
