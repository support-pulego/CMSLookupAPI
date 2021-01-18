using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("managedcareorganisations")]
    [ApiController]
    public class AccreditedMedicalCareOrganisationsController : ControllerBase
    {
        private readonly AccreditedMedicalCareOrganisationsContext _context;

        public AccreditedMedicalCareOrganisationsController(AccreditedMedicalCareOrganisationsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccreditedMedicalCareOrganisationsItem>>> GetAccreditedMedicalCareOrganisations()
        {
            // string sqlQuery = "Select 'MCO:  ' + CAST(a.ipkMCOID AS NVARCHAR(20)) AS  MCOID, ISNULL(a.sMCOName, N'') + '  (' + 'MCO:  ' + CAST(a.ipkMCOID AS NVARCHAR(20)) + ')' AS OrgName, isnull(convert(nvarchar(50), ac.dtDateFrom, 107), 0) As OrgActivateDate, isnull(convert(nvarchar(50), ac.dtDateTo, 107), 0) as OrgExpiry, isnull(i.sTitle, '') + isnull(i.sFullNames, N'') + ' ' + cast(isnull(i.sSurname, N'') as nvarchar(150))AS Contact, ISNULL(a.sPostalAddress, '') +' ' + ISNULL(a.sPostalCity, '') + ' ' + ISNULL(CAST(a.sPostalCode AS nvarchar(10)), N'') AS Address, ISNULL(a.sTelNo, '') AS Tel, a.ipkMCOID AS LinkId, ISNULL(a.sWebsite, '') AS WebAddress from [MCO].[MCO] a left join dbo.Accreditation ac on ac.ifkMCOID = a.ipkMCOID left join dbo.IndividualTypeLink itl on itl.ifkMCOID = a.ipkMCOID left join dbo.IndividualDetails i on i.ipkIndividualID = itl.ifkIndividualID where(a.bActive = 1) and itl.ifkIndividualTypeID = 10 and ifkAccreditationTypeID = 1 and itl.bActive = 'True' order by ISNULL(a.sMCOName, N'')";
            var data = await _context.AccreditedMadicalCareOrg.FromSqlRaw("EXECUTE dbo.spListAccreditedMCO").ToListAsync();
           // return await data.Select(mco =>
            foreach(var mco in data)
            {
                var webAddress = mco.WebAddress;
                if (!string.IsNullOrEmpty(webAddress) && !(webAddress.ToString().Contains("http") || webAddress.ToString().Contains("https")))
                {
                    mco.WebAddress = "https://" + webAddress;
                }

            };
            return data;
            // return await _context.AccreditedMadicalCareOrg.FromSqlRaw("EXECUTE dbo.spListAccreditedMCO").ToListAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<MCOServicesItem>>> GetServicesMedicalCareOrganisations(int id)
        {
            return await _context.MCOServices.FromSqlRaw("EXECUTE dbo.spGetMCOServicesWebDisplay  @ifkMCOID", new SqlParameter("@ifkMCOID", id)).ToListAsync();
        }

        [HttpGet("conditions/{ifkMCOID}")]
        public async Task<ActionResult<IEnumerable<MCOServicesDetailItem>>> GetConditionsMedicalCareOrganisations(int ifkMCOID, int complyPeriod)
        {
            return await _context.MCOServicesDetail.FromSqlRaw("EXECUTE dbo.spGetMCOConditionsByIDforWeb @ifkMCOID", new SqlParameter("@ifkMCOID", ifkMCOID)).ToListAsync();
        }

    }

}