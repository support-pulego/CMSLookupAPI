using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class AuditorContext : DbContext
    {

        public AuditorContext(DbContextOptions<AuditorContext> options) : base(options)
        {

        }

        public DbSet<AuditorItem> Auditor { get; set; }
    }
}
