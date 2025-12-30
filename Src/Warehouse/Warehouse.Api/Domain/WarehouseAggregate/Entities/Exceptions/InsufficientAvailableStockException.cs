using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions.Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InsufficientAvailableStockException : WarehouseDomainException
{
    public InsufficientAvailableStockException(string sku, int requested, int available) 
        : base($"موجودی قابل تخصیص برای کالا '{sku}' کافی نیست. (درخواست: {requested}، موجود: {available})", "Inventory.InsufficientStock") { }
}