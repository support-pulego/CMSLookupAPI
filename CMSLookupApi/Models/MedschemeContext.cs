using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class MedschemeContext : DbContext
    {
        public MedschemeContext(DbContextOptions<MedschemeContext> options)
            : base(options)
        {

        }

        public DbSet<MedschemeListItem> MedschemesList { get; set; }
        public DbSet<MedschemeItem> Medschemes { get; set; }
        public DbSet<MedschemeDetailItem> MedschemesRef { get; set; }
    }
}