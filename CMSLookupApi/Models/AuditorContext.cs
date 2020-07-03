using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
