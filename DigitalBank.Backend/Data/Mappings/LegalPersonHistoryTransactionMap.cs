using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class LegalPersonHistoryTransactionMap : IEntityTypeConfiguration<LegalPersonHistoryTransaction>
    {
        public void Configure(EntityTypeBuilder<LegalPersonHistoryTransaction> builder)
        {
            builder.HasOne(x => x.LegalPerson)
            .WithMany(x => x.LegalPersonHistoryTransaction)
            .HasForeignKey(x => x.LegalPersonID);

        }
    }
}
