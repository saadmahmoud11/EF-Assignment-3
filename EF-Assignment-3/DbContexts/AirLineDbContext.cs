using EF_Assignment_3.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Assignment_3.DbContexts;

public class AirLineDbContext : DbContext
{
    public AirLineDbContext() : base()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-B0U6UIT\\SQLEXPRESS;Database=AirLineDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AirLineDbContext).Assembly);
    }
    public DbSet<AirLine> AirLines { get; set; }
    public DbSet<AirCraft> AirCrafts { get; set; }
    public DbSet<AirCraftRoute> AirCraftRoutes { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<AirLinePhone> AirLinePhones { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Crew> Crews { get; set; }
    public DbSet<EmployeeQualification> EmployeeQualifications { get; set; }
}

