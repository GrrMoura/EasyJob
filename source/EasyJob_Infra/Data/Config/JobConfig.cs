using EasyJob_Business.Models.Vacancies.Jobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyJobs_Infra.Data.Config
{
    public class JobConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Jobs");


            builder.HasKey(v => v.Id);

            builder.Property(v => v.Title)
               .HasMaxLength(50)
               .IsRequired();
           
            builder.Property(v => v.HourPerWeek)
              .HasPrecision(6,2)
             .IsRequired();

            builder.Property(v => v.WeeklySalary)
            .HasPrecision(6, 2);

            builder.Property(v => v.BiWeeklySalary)
           .HasPrecision(6, 2);

            builder.Property(v => v.MonthlySalary)
            .HasPrecision(6, 2);

            builder.Property(v => v.MaxSalaryPerHour)
                .HasPrecision(4, 2);

            builder.Property(v => v.MinSalaryPerHour)
                .HasPrecision(4, 2);

            builder.Property(v => v.Note)
            .HasMaxLength(1000);
        }
    }
}