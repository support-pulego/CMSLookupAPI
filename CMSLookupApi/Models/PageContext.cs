using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class PageContext : DbContext
    {
        public PageContext(DbContextOptions<PageContext> options)
            : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
    }
}