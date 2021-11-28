using EasyJob_Business.Models.Subsectors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace EasyJobs_Infra.Data.Config
{
    class SubsectorConfig : IEntityTypeConfiguration<Subsector>
    {
        public void Configure(EntityTypeBuilder<Subsector> builder)
        {
            builder.ToTable("Subsectors");

            builder.HasKey(su => su.Id);

            builder.Property(su => su.Title)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
