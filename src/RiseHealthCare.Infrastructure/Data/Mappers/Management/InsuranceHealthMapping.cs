using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiseHealthCare.Domain.Management;

namespace RiseHealthCare.Infrastructure.Mappers.Management
{
    public class InsuranceHealthMapping : IEntityTypeConfiguration<InsuranceHealth>
    {
        public void Configure(EntityTypeBuilder<InsuranceHealth> builder)
        {
            builder.ToTable("Insurances");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Code)
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(i => i.Name)
                .HasColumnType("varchar(150)");

            builder.Property(i => i.DiscountType)
                .HasColumnType("varchar(20)")
                .HasConversion<string>();

            builder.Property(i => i.Discount)
                .HasColumnType("decimal(15,2)");
        }
    }
}