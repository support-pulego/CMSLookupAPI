using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("medschemes")]
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
        public async Task<ActionResult<IEnumerable<MedschemeListItem>>> GetMedSchemes(string filterBy)
        {
            string sql = "SELECT NAME AS 'SchemeName',isp_schemetypename AS 'SchemeType',address1_telephone2 AS Telephone,isp_schemestartdate AS 'RegistrationDate' FROM [dbo].[FilteredAccount] WHERE statecode = 0 AND statuscode IN (0,1,3) Order By Name Asc ";
            if (!string.IsNullOrEmpty(filterBy))
            {
                sql = "SELECT NAME AS 'SchemeName',isp_schemetypename AS 'SchemeType',address1_telephone2 AS Telephone,isp_schemestartdate AS 'RegistrationDate' FROM [dbo].[FilteredAccount] WHERE statecode = 0 AND statuscode IN (0,1,3) AND Name LIKE '" + filterBy.ToUpper() + "%' Order By Name Asc ";
            }

            return await _context.MedschemesList.FromSqlRaw(sql).ToListAsync();
        }

        // GET: api/medschemes/name
        [HttpGet("{name}")]
        public async Task<ActionResult<IEnumerable<MedschemeItem>>> GetMedSchemesByID(string name)
        {
            string sql = "SELECT name AS 'SchemeName', isp_schemetypename AS 'SchemeType', address1_telephone2 AS Telephone, isp_schemestartdate AS 'RegistrationDate', isp_schemereferencenumber, isp_previousname, isp_amalgamationschemeidname, fax, emailaddress2, websiteurl, address1_line1, address1_line2, address1_line3, address1_postalcode, address1_city, isp_address1province, address2_line1, address2_line2, address2_line3, address2_city, address2_postalcode, isp_address2province FROM FilteredAccount WHERE statecode = 0 AND statuscode IN (0,1,3) AND name = '"+name+"' Order By Name Asc ";

            return await _context.Medschemes.FromSqlRaw(sql).ToListAsync();
        }

        // GET: api/medschemes/name 
        [HttpGet("contacts/{refno}")]
        public async Task<ActionResult<IEnumerable<MedschemeDetailItem>>> GetMedSchemesByRefno(int refno)
        {
            string sql = "SELECT PersonName as Fullname, contacttype as Title, PersonTel as Telephone,PersonFax as Fax, PersonEmail as Email,PostalProvince as Province, PostalFull  FROM XRMInterface.dbo.SchemeContacts WHERE contacttypeid IN (11, 2, 13, 4, 6) AND active = 1 AND refno = " + refno.ToString();

            return await _context.MedschemesRef.FromSqlRaw(sql).ToListAsync();
        }

    }
}
