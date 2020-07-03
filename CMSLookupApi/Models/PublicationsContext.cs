using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class PublicationsContext : DbContext
    {
        public PublicationsContext(DbContextOptions<PublicationsContext> options) : base(options)
        {

        }
        public DbSet<PublicationItem> Publications {get; set;}
    }
}
