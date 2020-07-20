using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CardNumber).HasMaxLength(15);
            builder.Property(x => x.Cvv).HasMaxLength(3);
            builder.Property(x => x.ValidateCard).HasMaxLength(5);
            builder.Property(x => x.PrintedNameCard).HasMaxLength(25);

            builder.HasOne(x => x.PhisicalPerson)
               .WithOne(x => x.Card)
               .HasForeignKey<PhysicalPerson>(x => x.Id);

            builder.HasOne(x => x.LegalPerson)
            .WithOne(x => x.Card)
            .HasForeignKey<LegalPerson>(x => x.Id);

        }
    }
}
