using EntitleMentApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace EntitleMentApi.Context
{
    public class EntitleMentContext : DbContext
    {
        public EntitleMentContext(DbContextOptions<EntitleMentContext> options) : base(options) 
        {
           
        }

        public DbSet<TreeModel> Trees { get; set; }
        public DbSet<DefinitionModel> Definitions { get; set; }
        public DbSet<ValueModel> Values { get; set; }
    }
}
