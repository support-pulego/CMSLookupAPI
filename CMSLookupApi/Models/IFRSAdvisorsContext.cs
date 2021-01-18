using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class IFRSAdvisorsContext : DbContext
    {
        public IFRSAdvisorsContext(DbContextOptions<IFRSAdvisorsContext> options)
          : base(options)
        {

        }

        public DbSet<IFRSAdvisorsItem> IfrsAdvisors { get; set; }
    }
}
