using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiseHealthCare.Domain.MedicalCare;

namespace RiseHealthCare.Data.Mappers.MedicalCare
{
    public class PatientMapping : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patients");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.BirthDate)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.Genre)
                .HasConversion<string>()
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(p => p.CPF)
                .HasColumnType("varchar(15)");
            builder.HasIndex(p => p.CPF)
                .IsUnique();

            builder.Property(p => p.RG)
                .HasColumnType("varchar(25)");

            builder.Property(p => p.Information)
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Photo)
                .HasColumnType("varchar(100)");

            builder.OwnsOne(p => p.Address);

            builder.OwnsOne(p => p.Phone);
        }
    }
}