using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMSLookupApi.Models;

namespace CMSLookupApi.Controllers
{
    [Route("api/subcategories")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly SubCategoryContext _context;

        public SubCategoryController(SubCategoryContext context)
        {
            _context = context;
        }

        // GET: api/NewsItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategoryItem>>> GetSubCategories()
        {
            return await _context.SubCategories.ToListAsync();
        }

        // GET: api/NewsItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategoryItem>> GetCategoryItem(int id)
        {
            var subCategoryItem = await _context.SubCategories.FindAsync(id);

            if (subCategoryItem == null)
            {
                return NotFound();
            }

            return subCategoryItem;
        }

    }
}
