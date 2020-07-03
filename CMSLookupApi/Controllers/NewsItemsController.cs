using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMSLookupApi.Models;

namespace CMSLookupApi.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsItemsController : ControllerBase
    {
        private readonly NewsContext _context;

        public NewsItemsController(NewsContext context)
        {
            _context = context;
        }

        // GET: api/NewsItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsItem>>> GetNews()
        {
            return await _context.News.ToListAsync();
        }

        // GET: api/NewsItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewsItem>> GetNewsItem(int id)
        {
            var newsItem = await _context.News.FindAsync(id);

            if (newsItem == null)
            {
                return NotFound();
            }

            return newsItem;
        }

    }
}
