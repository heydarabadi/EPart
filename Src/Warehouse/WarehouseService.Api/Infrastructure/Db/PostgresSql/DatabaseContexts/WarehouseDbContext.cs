using Microsoft.EntityFrameworkCore;
using WarehouseService.Api.Domain.WarehouseAggregate.Entities.Models;

namespace WarehouseService.Api.Infrastructure.Db.PostgresSql.DatabaseContexts;

public sealed class WarehouseDbContext:DbContext
{
    public WarehouseDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    
    

    #region Db Sets
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public DbSet<StorageLocation> StorageLocations { get; set; }
    #endregion
    
    
    
    
    
}