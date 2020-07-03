using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class MedschemeContext : DbContext
    {
        public MedschemeContext(DbContextOptions<MedschemeContext> options)
            : base(options)
        {

        }

        public DbSet<MedschemeItem> Medschemes { get; set; }
    }
}