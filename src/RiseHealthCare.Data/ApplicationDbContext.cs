using Microsoft.EntityFrameworkCore;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.MedicalCare;
using RiseHealthCare.Domain.Shared.DomainObjects;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RiseHealthCare.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Management Context
        public DbSet<Professional> PoProfessionals { get; set; }

        public DbSet<InsuranceHealth> InsurancesHealth { get; set; }

        //MedicalCare Context
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<Entity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.RegisterDate = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = entry.Entity.Id;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}