using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class AccrediatedMedSchemeAdministatorContext : DbContext
    {
        public AccrediatedMedSchemeAdministatorContext(DbContextOptions<AccrediatedMedSchemeAdministatorContext> options)
            : base(options)
        {

        }

        public DbSet<AccrediatedMedSchemeAdministatorItem> AccrediatedMedSchemeAdministators { get; set; }
        public DbSet<SpAdminConditionsItem> SpAdmninConditionsByID { get; set; }
    }
}