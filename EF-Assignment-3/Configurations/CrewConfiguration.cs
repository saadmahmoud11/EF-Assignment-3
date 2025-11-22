using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_3.Configurations;

public class CrewConfiguration : IEntityTypeConfiguration<Crew>
{
    public void Configure(EntityTypeBuilder<Crew> builder)
    {
        builder.HasKey(x => x.AirCraftId);
        builder.HasOne(x => x.AirCraft)
               .WithOne(x => x.Crew)
               .HasForeignKey<Crew>(x => x.AirCraftId)
               .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.MajorPilot)
               .WithMany(x => x.MajorPilots)
               .HasForeignKey(x => x.MajorPilotId);
        builder.HasOne(x => x.AssistPilot)
                .WithMany(x => x.AssistPilots)
                .HasForeignKey(x => x.AssistPilotId);
        builder.HasOne(x => x.Host1)
                .WithMany(x => x.Host1s)
                .HasForeignKey(x => x.Host1Id);
        builder.HasOne(x => x.Host2)
                .WithMany(x => x.Host2s)
                .HasForeignKey(x => x.Host2Id);

    }
}
