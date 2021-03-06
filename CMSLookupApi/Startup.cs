using CMSLookupApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CMSLookupApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            services.AddDbContext<NewsContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("CMSWebConnectionString")));

            services.AddDbContext<PageContext>(opt =>
               opt.UseSqlServer(Configuration.GetConnectionString("CMSWebConnectionString")));

            services.AddDbContext<CategoryContext>(opt =>
               opt.UseSqlServer(Configuration.GetConnectionString("CMSWebConnectionString")));

            services.AddDbContext<SubCategoryContext>(opt =>
               opt.UseSqlServer(Configuration.GetConnectionString("CMSWebConnectionString")));

            services.AddDbContext<MedschemeContext>(opt =>
              opt.UseSqlServer(Configuration.GetConnectionString("XRMMSCRMConnectionString")));


            services.AddDbContext<AccrediatedMedSchemeAdministatorContext>(opt =>
              opt.UseSqlServer(Configuration.GetConnectionString("AccrediatedConnectionString")));

            services.AddDbContext<PublicationsContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("CMSWebConnectionString")));

            services.AddDbContext<IspAuditFirmContext>(opt =>
             opt.UseSqlServer(Configuration.GetConnectionString("XRMMSCRMConnectionString")));

            services.AddDbContext<AuditorContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("XRMMSCRMConnectionString")));

            services.AddDbContext<IFRSAdvisorsContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("XRMMSCRMConnectionString")));

            services.AddDbContext<AccreditedMedicalCareOrganisationsContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("AccrediatedConnectionString")));

            services.AddDbContext<AccreditedMedicalBrokeragesContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("XRMMSCRMConnectionString")));

            services.AddDbContext<SPComplaintContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("CMSCOMPVerConnectionString")));

            services.AddDbContext<InsurerCEOContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("DemarcationConnectionString")));

            services.AddDbContext<InsurersContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("DemarcationConnectionString")));

            services.AddDbContext<UnderwriterContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("DemarcationConnectionString")));

            services.AddDbContext<AdministratorCEOContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("DemarcationConnectionString")));
            
            services.AddDbContext<DistributorCEOContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("DemarcationConnectionString")));
            
            services.AddDbContext<ManagedCareCEOContext>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("DemarcationConnectionString")));

            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("EnableCORS");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
