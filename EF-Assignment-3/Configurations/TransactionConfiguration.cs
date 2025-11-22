using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF_Assignment_3.Entities;

namespace EF_Assignment_3.Configurations;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> b)
    {
        b.HasKey(x => x.Id);

        b.HasOne(x => x.AirLine)
         .WithMany(x => x.Transactions)
         .HasForeignKey(x => x.AirLineId);
    }
}



