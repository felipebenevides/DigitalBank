using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.PhisicalPerson)
               .WithOne(x => x.Account)
               .HasForeignKey<PhysicalPerson>(x => x.Id);

            builder.HasOne(x => x.LegalPerson)
            .WithOne(x => x.Account)
            .HasForeignKey<LegalPerson>(x => x.Id);

            builder.HasOne(x => x.Card)
             .WithOne(x => x.Account)
             .HasForeignKey<Account>(x => x.CardID);

        }
    }
}
