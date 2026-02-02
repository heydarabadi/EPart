using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class InventoryItemNotFoundException : WarehouseDomainException
{
    public InventoryItemNotFoundException(string sku) 
        : base($"کالایی با کد {sku} یافت نشد.", "Inventory.NotFound") { }
}