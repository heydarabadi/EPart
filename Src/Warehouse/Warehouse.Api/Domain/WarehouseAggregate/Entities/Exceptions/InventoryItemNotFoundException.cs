namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InventoryItemNotFoundException : WarehouseDomainException
{
    public InventoryItemNotFoundException(string sku) 
        : base($"کالایی با کد {sku} یافت نشد.", "Inventory.NotFound") { }
}