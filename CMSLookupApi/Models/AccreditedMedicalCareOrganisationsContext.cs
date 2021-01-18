using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class AccreditedMedicalCareOrganisationsContext : DbContext
    {
        public AccreditedMedicalCareOrganisationsContext(DbContextOptions<AccreditedMedicalCareOrganisationsContext> options)
        : base(options)
        {

        }

        public DbSet<AccreditedMedicalCareOrganisationsItem> AccreditedMadicalCareOrg { get; set; }

        public DbSet<MCOServicesItem> MCOServices { get; set; }
        public DbSet<MCOServicesDetailItem> MCOServicesDetail { get; set; }
    }
}
