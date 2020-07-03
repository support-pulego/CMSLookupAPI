using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSLookupApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Controllers
{
    [Route("api/brokers")]
    [ApiController]
    public class AccreditedMedicalBrokersBrokeragesController : ControllerBase
    {
        private readonly AccreditedMedicalBrokeragesContext _context;
        public AccreditedMedicalBrokersBrokeragesController(AccreditedMedicalBrokeragesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccreditedMedicalBrokerItem>>> GetAccreditedMedicalBrokers(string filterBy)
        {
            string sqlQuery = "SELECT Isp_BrokerId, Isp_name, Isp_AccreditationDate, Isp_AccreditationExpiry, Isp_AccreditationNumber, Isp_BrokerType, Isp_BrokerageId, Isp_PersonId, Cms_bmu_BrokerId FROM dbo.isp_BrokerExtensionBase WHERE Isp_BrokerageId IS NOT NULL";
            if(!string.IsNullOrEmpty(filterBy))
            {
                sqlQuery = "SELECT Isp_BrokerId, Isp_name, Isp_AccreditationDate, Isp_AccreditationExpiry, Isp_AccreditationNumber, Isp_BrokerType, Isp_BrokerageId, Isp_PersonId, Cms_bmu_BrokerId FROM dbo.isp_BrokerExtensionBase WHERE Isp_BrokerageId IS NOT NULL AND isp_name LIKE '" + filterBy.ToUpper() + "%'";
            }
                return await _context.AccreditedMediocalBrokers.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("Brokerages")]
        public async Task<ActionResult<IEnumerable<AccreditedMedicalBrokeragesItem>>> GetAccreditedMedicalBrokerages(string filterBy)
        {
            string sqlQuery = "SELECT Isp_BrokerageId,Isp_name,bmu_BrokerageId,Isp_AccreditationDate,Isp_AccreditationExpiry,Isp_AccreditationNumber,Isp_CallCentreNumber ,Isp_FaxNumber,Isp_StatusReason,Isp_TelephoneNumber,Isp_WebsiteURL,Isp_PersonId ,Isp_physicaladdressid,Isp_postaladdressid ,Isp_Address1Street1,Isp_Address1Street2 ,Isp_Address1Street3,Isp_Address1City ,Isp_Address2Street1 ,Isp_Address2Street2,Isp_Address2Street3,Isp_Address1Province,Isp_Address2,Isp_Address2City,Isp_Address1ZIPPostalCode, Isp_Address2ZIPPostalCode FROM dbo.isp_BrokerageExtensionBase";
            if (!string.IsNullOrEmpty(filterBy))
            {
                sqlQuery = "SELECT Isp_BrokerageId,Isp_name,bmu_BrokerageId,Isp_AccreditationDate,Isp_AccreditationExpiry,Isp_AccreditationNumber,Isp_CallCentreNumber ,Isp_FaxNumber,Isp_StatusReason,Isp_TelephoneNumber,Isp_WebsiteURL,Isp_PersonId ,Isp_physicaladdressid,Isp_postaladdressid ,Isp_Address1Street1,Isp_Address1Street2 ,Isp_Address1Street3,Isp_Address1City ,Isp_Address2Street1 ,Isp_Address2Street2,Isp_Address2Street3,Isp_Address1Province,Isp_Address2,Isp_Address2City,Isp_Address1ZIPPostalCode, Isp_Address2ZIPPostalCode FROM dbo.isp_BrokerageExtensionBase WHERE isp_name LIKE '" + filterBy.ToUpper() + "%'";
            }
            return await _context.AccreditedMediocalBrokerages.FromSqlRaw(sqlQuery).ToListAsync();
        }
    }
}