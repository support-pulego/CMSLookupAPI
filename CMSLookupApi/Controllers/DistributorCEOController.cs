using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("distributorceo")]
    [ApiController]
    public class DistributorCEOController : ControllerBase
    {
        private readonly DistributorCEOContext _context;

        public DistributorCEOController(DistributorCEOContext context)
        {
            _context = context;
        }

        [HttpGet("{distributorid}")]
        public async Task<ActionResult<IEnumerable<DistributorCEOItem>>> GetDistributorCEO(int distributorid)
        {
            string sqlQuery = "SELECT Dist.FkInsurerId as DistributorId,Dist.[PhysicalAddress],Dist.[PostalAddress],Dist.[Website],Dist.[Email],Dist.[Tel],Dist.[Fax],Dist.[CEO],Dist.[CompanyRegNo],Dist.[FSPNo] FROM [Distributor] Dist WHERE Dist.FkInsurerId =  " + distributorid;

            return await _context.DistributorService.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }

}