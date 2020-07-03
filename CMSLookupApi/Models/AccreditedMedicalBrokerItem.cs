using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class AccreditedMedicalBrokerItem
    {
        [Key]
        public Guid Isp_BrokerId { get; set; }
        public string Isp_name { get; set; }
        public DateTime Isp_AccreditationDate { get; set; }
        public DateTime Isp_AccreditationExpiry { get; set; }
        public string Isp_AccreditationNumber { get; set; }
        public int Isp_BrokerType { get; set; }
        public Guid Isp_BrokerageId { get; set; }
        public Guid Isp_PersonId { get; set; }
        public int Cms_bmu_BrokerId { get; set; }
    }
}
