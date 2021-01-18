using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class InsurerCEOContext : DbContext
    {
        public InsurerCEOContext(DbContextOptions<InsurerCEOContext> options) : base(options)
        {

        }

        public DbSet<InsurerCEOItem> InsurerService { get; set; }

    }
}
