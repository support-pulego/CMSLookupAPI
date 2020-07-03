using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options)
            : base(options)
        {

        }

        public DbSet<CategoryItem> Categories { get; set; }
    }
}