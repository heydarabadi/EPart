using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions.Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InvalidQuantityException : WarehouseDomainException
{
    public InvalidQuantityException(string action) 
        : base($"مقدار برای عملیات '{action}' باید عددی مثبت باشد.", "Inventory.InvalidQuantity") { }
}