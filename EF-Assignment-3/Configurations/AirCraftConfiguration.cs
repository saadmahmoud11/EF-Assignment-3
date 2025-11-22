using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

public class AirCraftConfiguration : IEntityTypeConfiguration<AirCraft>
{
    public void Configure(EntityTypeBuilder<AirCraft> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Crew)
               .WithOne(x => x.AirCraft)
               .HasForeignKey<Crew>(x => x.AirCraftId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.AirCraftRoutes)
                .WithOne(x => x.AirCraft)
                .HasForeignKey(x => x.AirCraftId)
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.AirLine)
               .WithMany(x => x.AirCrafts)
               .HasForeignKey(x => x.AirLineId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
