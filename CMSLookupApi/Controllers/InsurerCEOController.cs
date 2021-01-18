using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("insurerceo")]
    [ApiController]
    public class InsurerCEOController : ControllerBase
    {
        private readonly InsurerCEOContext _context;

        public InsurerCEOController(InsurerCEOContext context)
        {
            _context = context;
        }

        [HttpGet("{ceoid}")]
        public async Task<ActionResult<IEnumerable<InsurerCEOItem>>> GetInsurerCEO(int ceoid)
        {
            string sqlQuery = "SELECT dbo.[CEO].[CEOId],dbo.[CEO].[TitleOfCourtesy],dbo.[CEO].[FullNames], dbo.[CEO].[Email], dbo.[Insurer].[CompanyName], dbo.[Insurer].[PhysicalAddress], dbo.[Insurer].[PostalAddress], dbo.[Insurer].[Tel], dbo.[Insurer].[Fax], dbo.[Insurer].[Email] AS InsurerEmail, dbo.[Insurer].[CompanyRegNo], dbo.[Insurer].[FSPNo], dbo.[Insurer].[TradingName] FROM dbo.CEO JOIN dbo.[Insurer] ON dbo.[Insurer].FkCEOId = dbo.[CEO].CeoId WHERE dbo.Insurer.Active = 1 AND dbo.CEO.CeoId = " + ceoid;

            return await _context.InsurerService.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }

}