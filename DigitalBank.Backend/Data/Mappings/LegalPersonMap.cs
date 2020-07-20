using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class LegalPersonMap : IEntityTypeConfiguration<LegalPerson>
    {
        public void Configure(EntityTypeBuilder<LegalPerson> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CompanyName).HasMaxLength(25);
            builder.Property(x => x.CNPJ).HasMaxLength(11);
            builder.Property(x => x.Telephone).HasMaxLength(10);
            builder.Property(x => x.CellPhone).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.DigitalPassword).HasMaxLength(150);
            builder.Property(x => x.AccountType).HasMaxLength(10);
        }
    }
}
