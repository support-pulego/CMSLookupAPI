using CMSLookupApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMSLookupApi.Controllers
{
    [Route("pages")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly PageContext _context;

        public PageController(PageContext context)
        {
            _context = context;
        }

        // GET: api/NewsItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Page>>> GetPages()
        {
            return await _context.Pages.ToListAsync();
        }

        // GET: api/NewsItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Page>> GetPageItem(int id)
        {
            var pageItem = await _context.Pages.FindAsync(id);

            if (pageItem == null)
            {
                return NotFound();
            }

            return pageItem;
        }

    }
}
