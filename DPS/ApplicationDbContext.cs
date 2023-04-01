using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DPS
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<PC> PC { get; set; } 
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);


            var config = builder.Build();

            optionsBuilder.UseSqlServer(config["ConnectionString"]);
        }
    }
}

