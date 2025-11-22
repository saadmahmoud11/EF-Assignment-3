using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

public class AirLinePhoneConfiguration : IEntityTypeConfiguration<AirLinePhone>
{
    public void Configure(EntityTypeBuilder<AirLinePhone> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.AirLine)
               .WithMany(x => x.Phones)
               .HasForeignKey(x => x.AirLineId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
