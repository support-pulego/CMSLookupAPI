using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("administratorceo")]
    [ApiController]
    public class AdministratorCEOController : ControllerBase
    {
        private readonly AdministratorCEOContext _context;

        public AdministratorCEOController(AdministratorCEOContext context)
        {
            _context = context;
        }

        [HttpGet("{administratorid}")]
        public async Task<ActionResult<IEnumerable<AdministratorCEOItem>>> GetAdministratorCEO(int administratorid)
        {
            string sqlQuery = "SELECT Adm.[AdministratorId],Adm.[PhysicalAddress],Adm.[PostalAddress],Adm.[Website],Adm.[Email],Adm.[Tel],Adm.[Fax],Adm.[CEO],Adm.[CompanyRegNo],Adm.[FSPNo] FROM dbo.Administrator Adm WHERE Adm.FkInsurerId =  " + administratorid;

            return await _context.InsurerService.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }

}