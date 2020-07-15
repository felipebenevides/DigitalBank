using Data.Extensions;
//using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Context
{
    public class ConsertaeDBContext : DbContext
    {
        public ConsertaeDBContext(DbContextOptions options) : base(options)
        {
            //Database.ExecuteSqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.ApplyConfiguration(new ParticipantPushTokenMapping());

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries<ITrackableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("ModifyDate").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
