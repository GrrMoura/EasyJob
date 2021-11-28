using EasyJob_Business.Models.Sectors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyJobs_Infra.Data.Config
{
    class SectorConfig : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sector");

            builder.HasKey(v => v.Id);

            builder.Property(s => s.Title)
                .HasMaxLength(50)
                .IsRequired();

           

           

        }
    }
}
