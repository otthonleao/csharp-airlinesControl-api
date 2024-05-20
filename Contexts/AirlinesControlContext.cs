using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public DbSet<Voo> Voos => Set<Voo>();
        public DbSet<Cancellation> Cancellations => Set<Cancellation>();
        public DbSet<Maintenance> Maintenances => Set<Maintenance>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AirlinesControl"));
        }
    }
}