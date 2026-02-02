using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class InvalidWarehouseCapacityException : WarehouseDomainException
{
    public InvalidWarehouseCapacityException() : base("ظرفیت انبار باید عددی مثبت باشد.", "Warehouse.InvalidCapacity")
    {
    }
}