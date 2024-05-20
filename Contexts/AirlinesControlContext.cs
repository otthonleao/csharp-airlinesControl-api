using AirlinesControl.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirlinesControl.Contexts
{
    public class AirlinesControlContext: DbContext
    {
        private readonly IConfiguration _configuration;

        protected AirlinesControlContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Aircraft> Aircrafts => Set<Aircraft>();
        public DbSet<Pilot> Pilots => Set<Pilot>();
        public DbSet<Flight> Voos => Set<Flight>();
        public DbSet<Cancellation> Cancellations => Set<Cancellation>();
        public DbSet<Maintenance> Maintenances => Set<Maintenance>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AirlinesControl"));
        }
    }
}