using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public DbSet<AuditFirmFullDetail> AuditFirmDetailFull { get; set; }
    }
}
