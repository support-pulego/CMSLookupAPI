using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("auditor")]
    [ApiController]
    public class AuditorController : ControllerBase
    {
        private readonly AuditorContext _context;
        public AuditorController(AuditorContext context)
        {
            _context = context;
        }

        // GET: api/Auditor
        [HttpGet("{name}")]
        public async Task<ActionResult<IEnumerable<AuditorItem>>> GetAuditor(string name)
        {
            var sqlQuery = "SELECT  isp_name AS 'AuditorFirmName', isp_apptype AS 'AuthorisationType',isp_accreditationnumber AS 'AuthorisationNumber',isp_authorisationdate AS 'AuthorisationDate' , isp_authorisationdateutc AS 'AuthorisationDateUtc', isp_expirydate AS 'ExpiryDate', isp_expirydateutc AS 'ExpiryDateUtc', isp_declarationreviewedname AS 'DeclarationReviewedName' FROM dbo.Filteredisp_Auditor WHERE statuscode = 1 AND isp_accreditationnumber IS NOT NULL AND isp_auditfirmname LIKE '" + name.ToUpper() + "%' ORDER BY isp_name DESC";
            
            return await _context.Auditor.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }
}