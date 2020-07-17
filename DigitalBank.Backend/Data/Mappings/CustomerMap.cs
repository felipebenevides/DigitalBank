using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NickName).HasMaxLength(25);
            builder.Property(x => x.FullName).HasMaxLength(100);
            builder.Property(x => x.CPF).HasMaxLength(11);
            builder.Property(x => x.RG).HasMaxLength(9);
            builder.Property(x => x.Telephone).HasMaxLength(10);
            builder.Property(x => x.CellPhone).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.DigitalPassword).HasMaxLength(150);
            builder.Property(x => x.Gender).HasMaxLength(10);
        }
    }
}
