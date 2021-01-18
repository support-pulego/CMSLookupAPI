using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class DistributorCEOContext : DbContext
    {
        public DistributorCEOContext(DbContextOptions<DistributorCEOContext> options) : base(options)
        {

        }

        public DbSet<DistributorCEOItem> DistributorService { get; set; }

    }
}
