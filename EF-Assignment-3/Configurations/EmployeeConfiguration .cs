using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.AirLine)
               .WithMany(x => x.Employees)
               .HasForeignKey(x => x.AirLineId);

        builder.HasMany(x => x.Qualifications)
               .WithOne(x => x.Employee)
               .HasForeignKey(x => x.EmployeeId);
        builder.HasMany(x => x.MajorPilots)
               .WithOne(x => x.MajorPilot)
               .HasForeignKey(x => x.MajorPilotId)
               .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(x => x.AssistPilots)
                .WithOne(x => x.AssistPilot)
                .HasForeignKey(x => x.AssistPilotId)
                .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(x => x.Host1s)
                .WithOne(x => x.Host1)
                .HasForeignKey(x => x.Host1Id)
                .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(x => x.Host2s)
                .WithOne(x => x.Host2)
                .HasForeignKey(x => x.Host2Id)
                .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.Gender)
                .HasConversion<string>();
    }
}
