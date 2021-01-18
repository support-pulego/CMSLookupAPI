using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("managedcareceo")]
    [ApiController]
    public class ManagedCareCEOController : ControllerBase
    {
        private readonly ManagedCareCEOContext _context;

        public ManagedCareCEOController(ManagedCareCEOContext context)
        {
            _context = context;
        }

        // GET: api/managedcareceo
        [HttpGet("{insurerid}")]
        public async Task<ActionResult<IEnumerable<ManagedCareCEOItem>>> GetManagedCareCEO(int insurerid)
        {
            string sql = "SELECT Ins.InsurerId,Man.[PhysicalAddress],Man.[PostalAddress],Man.[Website], Man.[Email], Man.[Tel], Man.[Fax], Man.[CEO], Man.[CompanyRegNo], Man.[FSPNo]	FROM dbo.ManagedCare Man JOIN dbo.Insurer Ins ON Ins.FkManagedCareCEOId = Man.ManagedCareId WHERE Ins.InsurerId = " + insurerid;
          
            return await _context.ManagedCareCEOs.FromSqlRaw(sql).ToListAsync();

            //return await _context.ManagedCareCEOs.FromSqlRaw("EXECUTE dbo.GetManagedCareCEODetails @InsurerID", new SqlParameter("@InsurerID", insurerid)).ToListAsync();

        }

    }
}
