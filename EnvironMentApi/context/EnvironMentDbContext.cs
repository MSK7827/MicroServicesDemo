using EnvironMentApi.Model;
using Microsoft.EntityFrameworkCore;

namespace EnvironMentApi.context
{
    public class EnvironMentDbContext : DbContext
    {
        public EnvironMentDbContext(DbContextOptions<EnvironMentDbContext> options)
            : base(options)
        {

        }

        public DbSet<EnviornmentModel> Enviornments { get; set; }
    }
}
