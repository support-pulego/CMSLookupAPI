using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class SubCategoryContext : DbContext
    {
        public SubCategoryContext(DbContextOptions<SubCategoryContext> options)
            : base(options)
        {

        }

        public DbSet<SubCategoryItem> SubCategories { get; set; }
    }
}