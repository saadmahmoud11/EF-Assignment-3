using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

public class AirCraftRouteConfiguration : IEntityTypeConfiguration<AirCraftRoute>
{
    public void Configure(EntityTypeBuilder<AirCraftRoute> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.AirCraft)
               .WithMany(x => x.AirCraftRoutes)
               .HasForeignKey(x => x.AirCraftId)
               .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(x => x.Route)
               .WithMany(x => x.AirCraftRoutes)
               .HasForeignKey(x => x.RouteId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
