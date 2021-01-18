using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class UnderwriterContext : DbContext
    {
        public UnderwriterContext(DbContextOptions<UnderwriterContext> options) : base(options)
        {

        }

        public DbSet<UnderwriterItem> UnderwriterService { get; set; }

    }
}
