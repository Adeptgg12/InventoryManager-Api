using InventoryManager.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace InventoryManager.Infrastructure;

public class InventoryManagerDbContext : DbContext
{
    public InventoryManagerDbContext(DbContextOptions<InventoryManagerDbContext> options) : base(options)
    {
    }
    public DbSet<ProductModel> ProductTb { get; set; }
    public DbSet<StockTransactionModel> StockTransactionTb { get; set; }
}

public class InventoryManagerDbContextDesignFactory : IDesignTimeDbContextFactory<InventoryManagerDbContext>
{
    public InventoryManagerDbContext CreateDbContext(string[] args)
    {
        string connectionString = "Server=DESKTOP-DHD9UCL\\SQLEXPRESS;Database=InventoryDb;Trusted_Connection=True;TrustServerCertificate=True;";

        
        var optionsBuilder = new DbContextOptionsBuilder<InventoryManagerDbContext>().UseSqlServer(connectionString, opts => opts.CommandTimeout(600));
        return new InventoryManagerDbContext(optionsBuilder.Options);
    }
}
