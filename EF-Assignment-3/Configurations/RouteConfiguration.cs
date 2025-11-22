using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

public class RouteConfiguration : IEntityTypeConfiguration<Route>
{
    public void Configure(EntityTypeBuilder<Route> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasMany(x => x.AirCraftRoutes)
               .WithOne(x => x.Route)
               .HasForeignKey(x => x.RouteId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
