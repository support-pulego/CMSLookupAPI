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
    [Route("api/auditfirm")]
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
            string sqlQuery = "SELECT isp_auditfirmid AS 'AuditFirmID', isp_name AS 'AuditFirm',isp_accreditationnumber AS 'AuthorisationNumber', isp_expirydate AS 'StartDate', isp_expirydateutc AS 'Expirydate' FROM dbo.Filteredisp_auditfirm WHERE statuscode = 1 AND isp_accreditationnumber IS NOT NULL AND isp_expirydate >= GETDATE() Order By isp_name asc";
            if (!string.IsNullOrEmpty(filterBy))
            {
                sqlQuery = "SELECT isp_auditfirmid AS 'AuditFirmID', isp_name AS 'AuditFirm',isp_accreditationnumber AS 'AuthorisationNumber', isp_expirydate AS 'StartDate', isp_expirydateutc AS 'Expirydate' FROM dbo.Filteredisp_auditfirm WHERE statuscode = 1 AND isp_accreditationnumber IS NOT NULL AND isp_expirydate >= GETDATE() AND isp_name LIKE '" + filterBy.ToUpper() + "%' Order By isp_name asc";
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
            string sqlQuery = "SELECT con.isp_name AS 'AuditFirm', con.isp_Description AS 'Description', auditcon.isp_auditfirmid AS 'AuditFirmID', auditcon.isp_conditionid AS 'ConditionID' FROM dbo.isp_condition con INNER JOIN isp_auditfirm_isp_condition auditcon ON auditcon.isp_conditionid = con.isp_conditionId WHERE auditcon.isp_auditfirmid = '" + id.ToLower()+"'";

            return await _context.AuditFirmConditions.FromSqlRaw(sqlQuery).ToListAsync();
        }
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<AuditFirmFullDetail>>> GetAllAuditFirm()
        {
            string sqlQuery = "SELECT        auditfirm.isp_auditfirmid AS 'AuditFirmID', auditfirm.isp_name AS 'AuditFirm', auditfirm.isp_accreditationnumber AS 'AuthorisationNumber', auditfirm.isp_expirydate AS 'StartDate', auditfirm.isp_expirydateutc AS 'Expirydate',"+
                         "auditfirm.isp_address1city AS 'Address1City', auditfirm.isp_address1province AS 'Address1Province', auditfirm.isp_address1provincename AS 'Address1ProvinceName', auditfirm.isp_address1street1 AS 'Address1Street1', "+
                         "auditfirm.isp_address1street2 AS 'Address1Street2', auditfirm.isp_address1street3 AS 'Address1Street3', auditfirm.isp_address1zippostalcode AS 'Address1ZipPostalCode', auditfirm.isp_address2city AS 'Address2City', "+
                         "auditfirm.isp_address2province AS 'Address2Province', auditfirm.isp_address2provincename AS 'Address2ProvinceName', auditfirm.isp_address2street1 AS 'Address2Street1', "+
                         "auditfirm.isp_address2street2 AS 'Address2Street2', auditfirm.isp_address2street3 AS 'Address2Street3', auditfirm.isp_address2zippostalcode AS 'Address2ZipPostalCode', auditfirm.isp_apptype AS 'AuthorisationStatus',"+
                        "auditfirm.isp_vatregistrationnumber AS 'VatRegistrationNumber', auditfirm.isp_fax AS 'Fax', auditfirm.isp_email AS 'EmailAddress', auditfirm.isp_telephone AS 'Telephone', auditfirm.isp_website AS 'Website', "+
                        "isp_auditfirm_isp_condition.VersionNumber, isp_condition.isp_Description, isp_condition.isp_name, isp_condition.OwnerIdName, isp_condition.OwnerIdYomiName, isp_condition.OwnerIdDsc, isp_condition.isp_About, "+
                        "Filteredisp_ifrsadvisor.isp_employer, Filteredisp_ifrsadvisor.isp_membership, Filteredisp_ifrsadvisor.isp_saica, Filteredisp_ifrsadvisor.isp_person, Filteredisp_ifrsadvisor.isp_name AS Expr1"+
                        "FROM            Filteredisp_auditfirm AS auditfirm LEFT JOIN"+
                        "Filteredisp_ifrsadvisor ON auditfirm.isp_auditfirmid = Filteredisp_ifrsadvisor.isp_firmadvisorlinkid LEFT OUTER JOIN"+
                        "isp_auditfirm_isp_condition ON auditfirm.isp_auditfirmid = isp_auditfirm_isp_condition.isp_auditfirmid LEFT OUTER JOIN"+
                       "isp_condition ON isp_auditfirm_isp_condition.isp_conditionid = isp_condition.isp_conditionId"+
                      "WHERE(auditfirm.statuscode = 1) AND(auditfirm.isp_accreditationnumber IS NOT NULL) AND(auditfirm.isp_expirydate >= GETDATE())"+
                     "ORDER BY 'AuditFirm'";
            return await _context.AuditFirmDetailFull.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }
}