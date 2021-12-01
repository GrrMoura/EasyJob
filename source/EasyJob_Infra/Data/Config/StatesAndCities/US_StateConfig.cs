using EasyJob_Business.Models.StatesAndCities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EasyJob_Infra.Data.Config.StatesAndCities
{
    internal class US_StateConfig : IEntityTypeConfiguration<US_State>
    {
        public void Configure(EntityTypeBuilder<US_State> builder)
        {
            builder.ToTable("US_States");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.StateName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.StateCode).HasMaxLength(2).IsRequired();
        }
    }
}
