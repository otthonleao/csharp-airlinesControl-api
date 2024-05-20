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
        public DbSet<Aircraft> Aircrafts => Set<Aircraft>();
        public DbSet<Pilot> Pilots => Set<Pilot>();
        public DbSet<Voo> Voos => Set<Voo>();
        public DbSet<Cancellation> Cancellations => Set<Cancellation>();
        public DbSet<Maintenance> Maintenances => Set<Maintenance>();
    }
}