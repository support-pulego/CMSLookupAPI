using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("accrediatedmedschemeadministrators")]
    [ApiController]
    public class AccrediatedMedSchemeAdministatorController : ControllerBase
    {
        private readonly AccrediatedMedSchemeAdministatorContext _context;

        public AccrediatedMedSchemeAdministatorController(AccrediatedMedSchemeAdministatorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccrediatedMedSchemeAdministatorItem>>> GetMedSchemes()
        {
           var data = await _context.AccrediatedMedSchemeAdministators.FromSqlRaw("EXECUTE dbo.spListAccreditedAdmin").ToListAsync();
            foreach (var med in data)
            {
                var webAddress = med.WebAddress;
                if (!string.IsNullOrEmpty(webAddress) && !(webAddress.ToString().Contains("http") || webAddress.ToString().Contains("https")))
                {
                    med.WebAddress = "https://" + webAddress;
                }

            };
            return data;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<SpAdminConditionsItem>>> GetMedSchemeConditions(int id)
        {
            var parameters = new SqlParameter("@ifkAdminID", id);

            return await _context.SpAdmninConditionsByID.FromSqlRaw("EXECUTE dbo.spGetAdminConditionsByID @ifkAdminID", parameters).ToListAsync();
        }
    }
}
