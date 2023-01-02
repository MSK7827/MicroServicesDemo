using Microsoft.EntityFrameworkCore;
using SorApi.Model;

namespace SorApi.Context
{
    public class SorDbContext : DbContext
    {
        public SorDbContext( DbContextOptions<SorDbContext> options)
            :base(options) 
        {

        }

        public DbSet<SorModel> Sors { get; set; }
    }
}
