using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiseHealthCare.Domain.Management;

namespace RiseHealthCare.Infrastructure.Mappers.Management
{
    public class ProfessionalMapping : IEntityTypeConfiguration<Professional>
    {
        public void Configure(EntityTypeBuilder<Professional> builder)
        {
            builder.ToTable("Professionals");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Code)
                .HasColumnType("int")
                .IsRequired();
            builder.HasIndex(p => p.Code)
                .IsUnique();

            builder.Property(p => p.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Photo)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.HiringDate)
                .HasColumnType("datetime");

            builder.Property(p => p.FiringDate)
                .HasColumnType("datetime");

            builder.OwnsOne(p => p.Council, c =>
            {
                c.Property(co => co.Name)
                    .HasColumnType("varchar(100)");
                c.Property(co => co.RegistrationCode)
                    .HasColumnType("varchar(50)");
                c.Property(c => c.Estate)
                    .HasColumnType("varchar(15)");
            });

            builder.OwnsMany(p => p.Phones, ph =>
            {
                ph.Property(p => p.Number)
                    .HasColumnType("varchar(20)");
                ph.Property(p => p.NumberType)
                    .HasColumnType("varchar(25)")
                    .HasConversion<string>();
                ph.Property(p => p.IsWhatsapp)
                    .HasColumnType("bit");
            });

            builder.OwnsMany(p => p.Procedures, pro =>
            {
                pro.Property(p => p.Code)
                    .HasColumnType("int");

                pro.Property(p => p.Name)
                    .HasColumnType("varchar(100)");

                pro.Property(p => p.Deduction)
                    .HasColumnType("decimal(15,2)");

                pro.Property(p => p.Description)
                    .HasColumnType("varchar(100)");

                pro.Property(p => p.Price)
                    .HasColumnType("decimal(15,2)");

                pro.Property(p => p.TypeDeduction)
                    .HasColumnType("varchar(20)")
                    .HasConversion<string>();
            });

            builder.Property(p => p.Active)
                .HasColumnType("bit");
        }
    }
}