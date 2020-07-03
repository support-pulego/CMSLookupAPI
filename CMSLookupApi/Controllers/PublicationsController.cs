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
    [Route("api/publications")]
    [ApiController]
    public class PublicationsController : ControllerBase
    {
        private readonly PublicationsContext _context;
        public PublicationsController(PublicationsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PublicationItem>>> GetPublications()
        {
            string sqlQuery = "SELECT CategoryID, Description, FileName, Size AS 'FileSize', Created AS CreatedDate FROM [dbo].[Documents] WHERE CategoryID IS NOT NULL Order By Created Asc";
            return await _context.Publications.FromSqlRaw(sqlQuery).ToListAsync();
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<IEnumerable<PublicationItem>>> GetPublicationsByCategoryID(int categoryId)
        {
            string sql = "SELECT CategoryID, Description, FileName, Size AS 'FileSize', Created AS CreatedDate FROM [dbo].[Documents] WHERE CategoryId=" + categoryId + " Order By Created Asc";
            return await _context.Publications.FromSqlRaw(sql).ToListAsync();
        }

    }
}