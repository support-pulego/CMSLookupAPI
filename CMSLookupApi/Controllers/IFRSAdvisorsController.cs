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
    [Route("api/ifrsadvisors")]
    [ApiController]
    public class IFRSAdvisorsController : ControllerBase
    {
        private readonly IFRSAdvisorsContext _context;

        public IFRSAdvisorsController(IFRSAdvisorsContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IFRSAdvisorsItem>>> GetIFRSAdvisors(string filterBy)
        {
            string sqlQuery = "SELECT isp_ifrsadvisorid AS 'IFRSAdvisorID', isp_ifrsconsulting AS 'EntityName', isp_personname AS 'ExternalIFRSAdvisor', isp_name 'AuthorisationNumber',isp_declarationdate AS 'AuthorisationStartDate',isp_expirydate AS 'AuthorisationExpiryDate'  FROM dbo.Filteredisp_ifrsadvisor WHERE statuscode = 1 AND isp_type = 0 AND isp_name IS NOT NULL AND isp_expirydate IS NOT NULL AND isp_expirydate >= GETDATE() Order By isp_name ASC";
            if (!string.IsNullOrEmpty(filterBy))
            {
                sqlQuery = "SELECT isp_ifrsadvisorid AS 'IFRSAdvisorID', isp_ifrsconsulting AS 'EntityName', isp_personname AS 'ExternalIFRSAdvisor', isp_name 'AuthorisationNumber',isp_declarationdate AS 'AuthorisationStartDate',isp_expirydate AS 'AuthorisationExpiryDate'  FROM dbo.Filteredisp_ifrsadvisor WHERE statuscode = 1 AND isp_type = 0 AND isp_name IS NOT NULL AND isp_expirydate IS NOT NULL AND isp_expirydate >= GETDATE() AND isp_name LIKE '" + filterBy.ToUpper() + "%' Order By isp_name ASC";
            }
            return await _context.IfrsAdvisors.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<IFRSAdvisorsItem>>> GetIFRSAdvisorsByID(string id)
        {
            string sqlQuery = "SELECT isp_ifrsadvisorid AS 'IFRSAdvisorID', isp_ifrsconsulting AS 'EntityName', isp_personname AS 'ExternalIFRSAdvisor', isp_name 'AuthorisationNumber', isp_declarationdate AS 'AuthorisationStartDate',isp_expirydate AS 'AuthorisationExpiryDate'  FROM dbo.Filteredisp_ifrsadvisor WHERE isp_ifrsadvisorid = '" + id.ToLower()+"'";
            return await _context.IfrsAdvisors.FromSqlRaw(sqlQuery).ToListAsync();
        }
    }
}