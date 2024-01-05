using DotnetYuzuncuYilBireyselProje.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Repository
{
    public class AppDbContext:DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<ClientProfile> Clients { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
