using EasyJob_Business.Models.Addresses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EasyJobs_Infra.Data.Config
{
    public class AdressConfig : IEntityTypeConfiguration<Adress>
    {

        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Country)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.State)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.City)
                 .HasMaxLength(100)
                .IsRequired();

            
        }
    }
}
