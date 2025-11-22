using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

internal class EmployeeQualificationConfiguration : IEntityTypeConfiguration<EmployeeQualification>
{
    public void Configure(EntityTypeBuilder<EmployeeQualification> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Employee)
               .WithMany(x => x.Qualifications)
               .HasForeignKey(x => x.EmployeeId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
