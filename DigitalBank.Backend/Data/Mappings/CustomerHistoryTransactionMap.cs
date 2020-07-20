using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class CustomerHistoryTransactionMap : IEntityTypeConfiguration<CustomerHistoryTransaction>
    {
        public void Configure(EntityTypeBuilder<CustomerHistoryTransaction> builder)
        {
            builder.HasOne(x => x.PhysicalPerson)
                .WithMany(x => x.CustomerHistoryTransactions)
                .HasForeignKey(x => x.Id);

            builder.HasOne(x => x.LegalPerson)
            .WithMany(x => x.CustomerHistoryTransactions)
            .HasForeignKey(x => x.Id);

            builder.HasOne(x => x.HistoryTransaction)
                .WithMany(x => x.CustomerHistoryTransactions)
                .HasForeignKey(x => x.Id);

        }
    }
}
