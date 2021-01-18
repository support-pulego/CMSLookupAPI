using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class InsurersContext : DbContext
    {
        public InsurersContext(DbContextOptions<InsurersContext> options) : base(options)
        {

        }

        public DbSet<InsurersItem> InsurersService { get; set; }
        public DbSet<InsurerDetailItem> InsurerDetailService { get; set; }
        public DbSet<ProductDetailItem> ProductDetailService { get; set; }
        public DbSet<ProductOptionItem> ProductOptionService { get; set; }
        public DbSet<ProductConditionItem> ProductConditionsService { get; set; }
        public DbSet<InsurerConditionItem> InsurerConditionsService { get; set; }
        public DbSet<InsurerFSBDetailItem> InsureFSPDetailService { get; set; }

    }
}
