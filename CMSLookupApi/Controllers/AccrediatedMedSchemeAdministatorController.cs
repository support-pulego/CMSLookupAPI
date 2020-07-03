using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMSLookupApi.Models;
using Microsoft.Data.SqlClient;

namespace CMSLookupApi.Controllers
{
    [Route("api/accrediatedmedschemeadministators")]
    [ApiController]
    public class AccrediatedMedSchemeAdministatorController : ControllerBase
    {
        private readonly AccrediatedMedSchemeAdministatorContext _context;

        public AccrediatedMedSchemeAdministatorController(AccrediatedMedSchemeAdministatorContext context)
        {
            _context = context;
        }

        // GET: api/medschemes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccrediatedMedSchemeAdministatorItem>>> GetMedSchemes()
        {
            //This need to be replace by the store proc [dbo].[spListAccreditedAdminWeb]   from accreditation database. DO NOT forget to change the database connection
            //return await _context.AccrediatedMedSchemeAdministators.FromSqlRaw("SELECT AdminID, OrgName, OrgActivateDate, OrgExpiry, Contact, Address, Tel, LinkId, WebAddress FROM medadministrators").ToListAsync();
            return await _context.AccrediatedMedSchemeAdministators.FromSqlRaw("EXECUTE dbo.spListAccreditedAdmin").ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<SpAdminConditionsItem>>> GetMedSchemeConditions(int id)
        {
            var parameters = new SqlParameter("@ifkAdminID", id);
            
            return await _context.SpAdmninConditionsByID.FromSqlRaw("EXECUTE dbo.spGetAdminConditionsByID @ifkAdminID",parameters).ToListAsync();
        }
    }
}
