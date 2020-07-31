using Data.Mappings;
//using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Data.Context
{
    public class DigitalBankDBContext : DbContext
    {
        public DigitalBankDBContext(DbContextOptions<DigitalBankDBContext> options) : base(options)
        //public DigitalBankDBContext(DbContextOptions<DigitalBankDBContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql();
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<PhysicalPerson> PhysicalPerson { get; set; }
        public DbSet<LegalPerson> LegalPerson { get; set; }
        public DbSet<LegalPersonHistoryTransaction> CustomerHistoryTransaction { get; set; }
        public DbSet<HistoryTransaction> HistoryTransaction { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountMap());
            modelBuilder.ApplyConfiguration(new CardMap());
            modelBuilder.ApplyConfiguration(new LegalPersonHistoryTransactionMap());
            modelBuilder.ApplyConfiguration(new LegalPersonMap());
            modelBuilder.ApplyConfiguration(new HistoryTransactionMap());


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
