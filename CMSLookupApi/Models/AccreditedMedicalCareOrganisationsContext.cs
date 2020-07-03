using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
