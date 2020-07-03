using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class AccreditedMedicalBrokeragesItem
    {
        [Key]
        public Guid Isp_BrokerageId { get; set; }
        public string Isp_name { get; set; }
        public int Bmu_BrokerageId { get; set; }
        public DateTime Isp_AccreditationDate { get; set; }
        public DateTime Isp_AccreditationExpiry { get; set; }
        public string Isp_AccreditationNumber { get; set; }
        public string Isp_CallCentreNumber { get; set; }
        public string Isp_FaxNumber { get; set; }
        public string Isp_StatusReason { get; set; }
        public string Isp_TelephoneNumber { get; set; }
        public string Isp_WebsiteURL { get; set; }
        public string Isp_PersonId { get; set; }
        public string Isp_physicaladdressid { get; set; }
        public string Isp_postaladdressid { get; set; }
        public string Isp_Address1Street1 { get; set; }
        public string Isp_Address1Street2 { get; set; }
        public string Isp_Address1Street3 { get; set; }
        public string Isp_Address1City { get; set; }
        public string Isp_Address2Street1 { get; set; }
        public string Isp_Address2Street2 { get; set; }
        public string Isp_Address2Street3 { get; set; }
        public string Isp_Address1Province { get; set; }
        public string Isp_Address2 { get; set; }
        public string Isp_Address2City { get; set; }
        public string Isp_Address1ZIPPostalCode { get; set; }
        public string Isp_Address2ZIPPostalCode { get; set; }
    }
}
