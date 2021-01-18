using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class IspAuditFirmContext : DbContext
    {
        public IspAuditFirmContext(DbContextOptions<IspAuditFirmContext> options) : base(options)
        {

        }

        public DbSet<AuditFirmItem> AuditFirms { get; set; }
        public DbSet<AuditFirmDetailItem> AuditFirmDetail { get; set; }
        public DbSet<AuditFirmConditionsItem> AuditFirmConditions { get; set; }
    }
}
