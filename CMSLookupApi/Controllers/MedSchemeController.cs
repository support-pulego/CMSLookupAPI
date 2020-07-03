using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMSLookupApi.Models;

namespace CMSLookupApi.Controllers
{
    [Route("api/medschemes")]
    [ApiController]
    public class MedSchemeController : ControllerBase
    {
        private readonly MedschemeContext _context;

        public MedSchemeController(MedschemeContext context)
        {
            _context = context;
        }

        // GET: api/medschemes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedschemeItem>>> GetMedSchemes(string filterBy)
        {
            string sql = "SELECT NAME AS 'SchemeName',isp_schemetypename AS 'SchemeType',address1_telephone2 AS Telephone,isp_schemestartdate AS 'RegistrationDate' FROM [dbo].[FilteredAccount] WHERE statecode = 0 AND statuscode IN (0,1,3) Order By Name Asc ";
            if (!string.IsNullOrEmpty(filterBy)) 
            {
              sql = "SELECT NAME AS 'SchemeName',isp_schemetypename AS 'SchemeType',address1_telephone2 AS Telephone,isp_schemestartdate AS 'RegistrationDate' FROM [dbo].[FilteredAccount] WHERE statecode = 0 AND statuscode IN (0,1,3) AND Name LIKE '" + filterBy.ToUpper()+"%' Order By Name Asc ";
            }

            return await _context.Medschemes.FromSqlRaw(sql).ToListAsync();
        }

        // GET: api/medschemes/id
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<MedschemeItem>>> GetMedSchemesByID(string id)
        {
            string sql = "SELECT NAME AS 'SchemeName',isp_schemetypename AS 'SchemeType',address1_telephone2 AS Telephone,isp_schemestartdate AS 'RegistrationDate' FROM [dbo].[FilteredAccount] WHERE statecode = 0 AND statuscode IN (0,1,3) Order By Name Asc ";
            
            return await _context.Medschemes.FromSqlRaw(sql).ToListAsync();
        }

    }
}
