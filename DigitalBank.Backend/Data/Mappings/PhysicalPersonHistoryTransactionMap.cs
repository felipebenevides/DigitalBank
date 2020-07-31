using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class PhysicalPersonHistoryTransactionMap : IEntityTypeConfiguration<PhysicalPersonHistoryTransaction>
    {
        public void Configure(EntityTypeBuilder<PhysicalPersonHistoryTransaction> builder)
        {
            builder.HasOne(x => x.PhysicalPerson)
                .WithMany(x => x.PhysicalPersonHistoryTransaction)
                .HasForeignKey(x => x.PhysicalPersonID);

        }
    }
}
