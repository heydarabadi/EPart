using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions.Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class ShippingExceedsReservedQuantityException : WarehouseDomainException
{
    public ShippingExceedsReservedQuantityException(int shipQty, int reservedQty) 
        : base($"مقدار خروجی ({shipQty}) نمی‌تواند از مقدار رزرو شده ({reservedQty}) بیشتر باشد.", "Inventory.ShippingError") { }
}