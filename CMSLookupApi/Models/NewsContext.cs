using Microsoft.EntityFrameworkCore;

namespace CMSLookupApi.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {

        }

        public DbSet<NewsItem> News { get; set; }
    }
}