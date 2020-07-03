using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
