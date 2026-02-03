using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseService.Api.Domain.WarehouseAggregate.Entities.Models;
using WarehouseService.Api.Domain.WarehouseAggregate.ValueObjects.Objects;

namespace WarehouseService.Api.Infrastructure.Db.PostgresSql.EntityConfigurations;

public sealed class WarehouseConfiguration:IEntityTypeConfiguration<Warehouse>
{
    public void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasIndex(x => x.Id).IsUnique();
        
        builder.HasMany(x=>x.StorageLocations)
            .WithOne(x=>x.Warehouse)
            .HasForeignKey(x => x.WarehouseId);

        builder.ComplexProperty(x => x.Location);
        builder.Property(x => x.IsActive).HasDefaultValue(true);

    }
}