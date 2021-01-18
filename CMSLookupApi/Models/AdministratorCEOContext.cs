using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class AdministratorCEOContext : DbContext
    {
        public AdministratorCEOContext(DbContextOptions<AdministratorCEOContext> options) : base(options)
        {

        }

        public DbSet<AdministratorCEOItem> InsurerService { get; set; }

    }
}
