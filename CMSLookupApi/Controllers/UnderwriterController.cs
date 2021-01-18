using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("underwriter")]
    [ApiController]
    public class UnderwriterController : ControllerBase
    {
        private readonly UnderwriterContext _context;

        public UnderwriterController(UnderwriterContext context)
        {
            _context = context;
        }

        [HttpGet("{underwriterid}/{insurerid}")]
        public async Task<ActionResult<IEnumerable<UnderwriterItem>>> GetUnderwriter(int underwriterid, int insurerid)
        {
            string sqlQuery = "SELECT dbo.[Insurer].[CompanyName] AS Insurer, dbo.[Underwriter].[UnderwriterName], dbo.[Underwriter].[PhysicalAddress], dbo.[Underwriter].[PostalAddress], dbo.[Underwriter].[Website], dbo.[Underwriter].[Email], dbo.[Underwriter].[Tel], dbo.[Underwriter].[Fax], dbo.[Underwriter].[CEO], dbo.[Underwriter].[CompanyRegNo], dbo.[Underwriter].[FSPNo], dbo.[Underwriter].[TradingName] FROM dbo.Underwriter JOIN dbo.Insurer ON Insurer.FkUnderwriterId = " + underwriterid + " WHERE dbo.Underwriter.UnderwriterId = " + underwriterid + " AND dbo.Insurer.InsurerId = " + insurerid;

            return await _context.UnderwriterService.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }

}
