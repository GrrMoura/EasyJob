using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EasyJob_Business.Models.Addresses;
using EasyJob_Business.Models.Sectors;
using EasyJob_Business.Models.Subsectors;
using EasyJob_Business.Models.Users;
using EasyJob_Business.Models.Vacancies.Jobs;
using EasyJob_Infra.Data.Config;
using EasyJobs_Infra.Data.Config;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyJob_Infra.Data.DbAplications
{
    public partial class DbApplication : IdentityDbContext<IdentityUser>
    {
        public DbApplication(DbContextOptions<DbApplication> context) : base(context) { }

        public DbApplication() { }

        public DbSet<User> User { get; set; }
        public DbSet<Job> Jobs { get; set; } 
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Subsector> Subsectors { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdressConfig());
            modelBuilder.ApplyConfiguration(new JobConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new SectorConfig());
            modelBuilder.ApplyConfiguration(new SubsectorConfig());

            modelBuilder.Entity<User>().HasQueryFilter(p=>p.Active==true); // para pegar apenas os ativos
            modelBuilder.Entity<Job>().HasQueryFilter(p => p.Active == true);

            base.OnModelCreating(modelBuilder);
        }

       
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.GetType().GetProperty("CreationTime") == null))
            {
                if (entry.State == EntityState.Added)
                {
                    try
                    {
                        entry.Property("CreationTime").CurrentValue = DateTime.Now;
                    }
                    catch (Exception)
                    {

                    }
                   
                }

                if (entry.State == EntityState.Modified)
                {
                    try
                    {
                        entry.Property("CreationTime").IsModified = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        
                    }
                    
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }
}
