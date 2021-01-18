using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class SPComplaintContext : DbContext
    {
        public SPComplaintContext(DbContextOptions<SPComplaintContext> options) : base(options)
        {

        }

        public DbSet<ComplaintResponseItem> SpCompliant { get; set; }
        public DbSet<ComplaintCategoryAgainstItem> CategoryAgainst { get; set; }
        public DbSet<ComplaintCategoryByItem> CategoryBy { get; set; }
        public DbSet<EntityListItem> EntityList { get; set; }
        public DbSet<ProvinceItem> ProvinceData { get; set; }
        public DbSet<SchemeBenefitOptionsItem> SchemeBenefitOptions { get; set; }
        public DbSet<TitleItem> TitleList { get; set; }
        public DbSet<ComplaintStatusItem> ComplaintStatus { get; set; }
    }
}
