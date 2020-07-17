using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class HistoryTransactionMap : IEntityTypeConfiguration<HistoryTransaction>
    {
        public void Configure(EntityTypeBuilder<HistoryTransaction> builder)
        {
            builder.ToTable("HistoryTransaction");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Amount).HasColumnType("decimal(18,2)");
            builder.Property(x => x.TransactionCost).HasColumnType("decimal(18,2)");
            builder.Property(x => x.PaymentType).HasMaxLength(10);

        }
    }
}
