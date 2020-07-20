using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mappings
{
    public class PhysicalPersonMap : IEntityTypeConfiguration<PhysicalPerson>
    {
        public void Configure(EntityTypeBuilder<PhysicalPerson> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NickName).HasMaxLength(25);
            builder.Property(x => x.FullName).HasMaxLength(100);
            builder.Property(x => x.CPF).HasMaxLength(11);
            builder.Property(x => x.Telephone).HasMaxLength(10);
            builder.Property(x => x.CellPhone).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.DigitalPassword).HasMaxLength(150);
            builder.Property(x => x.Gender).HasMaxLength(10);
        }
    }
}
