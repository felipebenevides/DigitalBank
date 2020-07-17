using Data.Extensions;
using Data.Mappings;
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
        }

        public DbSet<Card> Card { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerHistoryTransaction> CustomerHistoryTransaction { get; set; }
        public DbSet<HistoryTransaction> HistoryTransaction { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardMap());
            modelBuilder.ApplyConfiguration(new CustomerHistoryTransactionMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new HistoryTransactionMap());

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
