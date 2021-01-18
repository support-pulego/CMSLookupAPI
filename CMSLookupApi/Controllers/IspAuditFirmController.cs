using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("auditfirm")]
    [ApiController]
    public class IspAuditFirmController : ControllerBase
    {
        private readonly IspAuditFirmContext _context;
        public IspAuditFirmController(IspAuditFirmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuditFirmItem>>> GetAuditFirm(string filterBy)
        {
            string sqlQuery = "SELECT isp_auditfirmid AS 'AuditFirmID', isp_name AS 'AuditFirm',isp_accreditationnumber AS 'AuthorisationNumber', isp_expirydate AS 'StartDate', isp_expirydateutc AS 'ExpiryDate' FROM dbo.Filteredisp_auditfirm WHERE statuscode = 1 AND isp_accreditationnumber IS NOT NULL AND isp_expirydate >= GETDATE() Order By isp_name asc";
            if (!string.IsNullOrEmpty(filterBy))
            {
                sqlQuery = "SELECT isp_auditfirmid AS 'AuditFirmID', isp_name AS 'AuditFirm',isp_accreditationnumber AS 'AuthorisationNumber', isp_expirydate AS 'StartDate', isp_expirydateutc AS 'ExpiryDate' FROM dbo.Filteredisp_auditfirm WHERE statuscode = 1 AND isp_accreditationnumber IS NOT NULL AND isp_expirydate >= GETDATE() AND isp_name LIKE '" + filterBy.ToUpper() + "%' Order By isp_name asc";
            }

           return await _context.AuditFirms.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AuditFirmDetailItem>>> GetAuditFirmByID(string id)
        {
            string sqlQuery = "SELECT isp_auditfirmid AS 'AuditFirmID', isp_name AS 'AuditFirm',isp_accreditationnumber AS 'AuthorisationNumber', isp_expirydate AS 'StartDate', isp_expirydateutc AS 'Expirydate',isp_address1city AS 'Address1City',isp_address1province AS 'Address1Province',isp_address1provincename AS 'Address1ProvinceName',isp_address1street1 AS 'Address1Street1',isp_address1street2 AS 'Address1Street2',isp_address1street3 AS 'Address1Street3', isp_address1zippostalcode AS 'Address1ZipPostalCode',isp_address2city AS 'Address2City',isp_address2province AS 'Address2Province',isp_address2provincename AS 'Address2ProvinceName',isp_address2street1 AS 'Address2Street1',isp_address2street2 AS 'Address2Street2',isp_address2street3 AS 'Address2Street3',isp_address2zippostalcode AS 'Address2ZipPostalCode', isp_apptype AS 'AuthorisationStatus', isp_vatregistrationnumber AS 'VatRegistrationNumber', isp_fax AS 'Fax', isp_email AS 'EmailAddress', isp_telephone AS 'Telephone', isp_website AS 'Website' FROM dbo.Filteredisp_auditfirm WHERE isp_auditfirmid = '" + id.ToLower() + "'";

            return await _context.AuditFirmDetail.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("conditions/{id}")]
        public async Task<ActionResult<IEnumerable<AuditFirmConditionsItem>>> GetAuditFirmConditionsByAuditFirmID(string id)
        {
            string sqlQuery = "SELECT con.isp_name AS 'AuditFirm', con.isp_Description AS 'Description', auditcon.isp_auditfirmid AS 'AuditFirmID', auditcon.isp_conditionid AS 'ConditionID' FROM dbo.isp_condition con INNER JOIN isp_auditfirm_isp_condition auditcon ON auditcon.isp_conditionid = con.isp_conditionId WHERE auditcon.isp_auditfirmid = '" + id.ToLower() + "'";

            return await _context.AuditFirmConditions.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }
}