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
    [Route("api/auditor")]
    [ApiController]
    public class AuditorController : ControllerBase
    {
        private readonly AuditorContext _context;
        public AuditorController(AuditorContext context)
        {
            _context = context;
        }

        // GET: api/Auditor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuditorItem>>> GetAuditor(string filterBy)
        {
            string sqlQuery = "SELECT  isp_name AS 'AuditorFirmName', isp_apptype AS 'AuthorisationType',isp_accreditationnumber AS 'AuthorisationNumber',isp_authorisationdate AS 'AuthorisationDate' , isp_authorisationdateutc AS 'AuthorisationDateUtc', isp_expirydate AS 'ExpiryDate', isp_expirydateutc AS 'ExpiryDateUtc', isp_declarationreviewedname AS 'DeclarationReviewedName' FROM dbo.Filteredisp_Auditor WHERE statuscode = 1 AND isp_accreditationnumber IS NOT NULL ORDER BY isp_name DESC";
            if (!string.IsNullOrEmpty(filterBy)) 
            {
                sqlQuery = "SELECT  isp_name AS 'AuditorFirmName', isp_apptype AS 'AuthorisationType',isp_accreditationnumber AS 'AuthorisationNumber',isp_authorisationdate AS 'AuthorisationDate' , isp_authorisationdateutc AS 'AuthorisationDateUtc', isp_expirydate AS 'ExpiryDate', isp_expirydateutc AS 'ExpiryDateUtc', isp_declarationreviewedname AS 'DeclarationReviewedName' FROM dbo.Filteredisp_Auditor WHERE statuscode = 1 AND isp_accreditationnumber IS NOT NULL AND isp_name LIKE '" + filterBy.ToUpper() + "%' ORDER BY isp_name DESC";
            }
            return await _context.Auditor.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }
}