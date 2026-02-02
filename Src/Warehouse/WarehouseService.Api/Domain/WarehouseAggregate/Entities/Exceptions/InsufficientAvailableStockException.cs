using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class InsufficientAvailableStockException : WarehouseDomainException
{
    public InsufficientAvailableStockException(string sku, int requested, int available) 
        : base($"موجودی قابل تخصیص برای کالا '{sku}' کافی نیست. (درخواست: {requested}، موجود: {available})", "Inventory.InsufficientStock") { }
}