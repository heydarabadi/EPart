namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InvalidWarehouseCapacityException : WarehouseDomainException
{
    public InvalidWarehouseCapacityException() : base("ظرفیت انبار باید عددی مثبت باشد.", "Warehouse.InvalidCapacity")
    {
    }
}