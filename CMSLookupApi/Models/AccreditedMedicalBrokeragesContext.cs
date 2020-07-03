using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSLookupApi.Models
{
    public class AccreditedMedicalBrokeragesContext : DbContext
    {
        public AccreditedMedicalBrokeragesContext(DbContextOptions<AccreditedMedicalBrokeragesContext> options)
       : base(options)
        {

        }

        public DbSet<AccreditedMedicalBrokeragesItem> AccreditedMediocalBrokerages { get; set; }

        public DbSet<AccreditedMedicalBrokerItem> AccreditedMediocalBrokers { get; set; }
    }
}
