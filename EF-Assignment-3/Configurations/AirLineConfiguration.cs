using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

public class AirLineConfiguration : IEntityTypeConfiguration<AirLine>
{
    public void Configure(EntityTypeBuilder<AirLine> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.AirCrafts)
            .WithOne(x => x.AirLine)
            .HasForeignKey(x => x.AirLineId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Employees)
            .WithOne(x => x.AirLine)
            .HasForeignKey(x => x.AirLineId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Transactions)
            .WithOne(x => x.AirLine)
            .HasForeignKey(x => x.AirLineId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Phones)
            .WithOne(x => x.AirLine)
            .HasForeignKey(x => x.AirLineId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
