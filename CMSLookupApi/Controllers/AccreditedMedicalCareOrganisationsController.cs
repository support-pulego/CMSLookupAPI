using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSLookupApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Controllers
{
    [Route("api/managedcareorganisations")]
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
            string sqlQuery = "Select 'MCO:  ' + CAST(a.ipkMCOID AS NVARCHAR(20)) AS  MCOID, ISNULL(a.sMCOName, N'') + '  (' + 'MCO:  ' + CAST(a.ipkMCOID AS NVARCHAR(20)) + ')' AS OrgName, isnull(convert(nvarchar(50), ac.dtDateFrom, 107), 0) As OrgActivateDate, isnull(convert(nvarchar(50), ac.dtDateTo, 107), 0) as OrgExpiry, isnull(i.sTitle, '') + isnull(i.sFullNames, N'') + ' ' + cast(isnull(i.sSurname, N'') as nvarchar(150))AS Contact, ISNULL(a.sPostalAddress, '') +' ' + ISNULL(a.sPostalCity, '') + ' ' + ISNULL(CAST(a.sPostalCode AS nvarchar(10)), N'') AS Address, ISNULL(a.sTelNo, '') AS Tel, a.ipkMCOID AS LinkId, ISNULL(a.sWebsite, '') AS WebAddress from [MCO].[MCO] a left join dbo.Accreditation ac on ac.ifkMCOID = a.ipkMCOID left join dbo.IndividualTypeLink itl on itl.ifkMCOID = a.ipkMCOID left join dbo.IndividualDetails i on i.ipkIndividualID = itl.ifkIndividualID where(a.bActive = 1) and itl.ifkIndividualTypeID = 10 and ifkAccreditationTypeID = 1 and itl.bActive = 'True' order by ISNULL(a.sMCOName, N'')";

            return await _context.AccreditedMadicalCareOrg.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("MCOService/{ifkMCOID}")]
        public async Task<ActionResult<IEnumerable<MCOServicesItem>>> GetServicesMedicalCareOrganisations(int ifkMCOID)
        {
            string sqlQuery = "select ipkServicesId, ifkMCOServicesID,ifkMCOID,bActive, ipkMCOServicesID, sShortDescription, sDescription, ifkMCOID, bIsGroupHeader, bIsSubItem, iIsSubItemFor, bActive, iOrder, 'yes' as true  from MCO.MCOServicesLink l inner join MCO.MCOServices s on l.ifkMCOServicesID = s.ipkMCOServicesID where l.ifkMCOID = " + ifkMCOID+" and s.bActive = 1 and l.bActive = 1  order by ifkMCOServicesID";

            return await _context.MCOServices.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("MCOConditions/{ifkMCOID}/{complyPeriod}")]
        public async Task<ActionResult<IEnumerable<MCOServicesItem>>> GetConditionsMedicalCareOrganisations(int ifkMCOID,int complyPeriod)
        {
            string sqlQuery = "SELECT c.ipkMCOCondID as 'ConditionID', l.ifkMCOCondID, c.sShortDesc, c.sDescription, 'yes' as true, bIsSubItem, p.iConditionPeriod FROM dbo.MCOConditions c inner join dbo.MCOConditionLink l on c.ipkMCOCondID = l.ifkMCOCondID inner join dbo.ConditionPeriod p on p.ipkCondPeriodID = l.ifkCondPeriodID where c.bActive = 'true' and l.ifkMCOID = "+ifkMCOID+" and p.iConditionPeriod = "+ complyPeriod + " order by c.iorder";

            return await _context.MCOServices.FromSqlRaw(sqlQuery).ToListAsync();
        }

    }
    
}