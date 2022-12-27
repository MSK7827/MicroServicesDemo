using InstitutionApi.Model;
using Microsoft.EntityFrameworkCore;

namespace InstitutionApi.Context
{
    public class InstitutionDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public InstitutionDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("conn"));
        }
        public InstitutionDbContext(DbContextOptions<InstitutionDbContext> options)
          : base(options)
        {

        }

        public DbSet<InstitutionModel> Institutions { get; set; }
    }
}
