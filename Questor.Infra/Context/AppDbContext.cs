using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Questor.Domain.Entities;
using System.Diagnostics;

namespace Questor.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<Banco> Bancos { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(message => Debug.WriteLine(message));

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "ConnectionStrings:Database",
                    sqlServerOptions => sqlServerOptions.MigrationsAssembly("Questor.Infra"));
            }
        }

    }
}
