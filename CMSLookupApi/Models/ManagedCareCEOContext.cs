using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class ManagedCareCEOContext : DbContext
    {
        public ManagedCareCEOContext(DbContextOptions<ManagedCareCEOContext> options) : base(options)
        {

        }

        public DbSet<ManagedCareCEOItem> ManagedCareCEOs { get; set; }

    }
}
