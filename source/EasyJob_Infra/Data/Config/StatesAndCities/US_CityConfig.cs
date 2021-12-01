using EasyJob_Business.Models.StatesAndCities;
using Microsoft.EntityFrameworkCore;

namespace EasyJob_Infra.Data.Config.StatesAndCities
{
    public class US_CityConfig : IEntityTypeConfiguration<US_City>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<US_City> builder)
        {
            builder.ToTable("US_Cities");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CityName).HasMaxLength(50).IsRequired();


        }
    }
}
