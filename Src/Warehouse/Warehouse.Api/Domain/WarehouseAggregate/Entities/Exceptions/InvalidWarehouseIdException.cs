namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

// اکسپشن برای شناسه‌های خالی یا نامعتبر
public class InvalidWarehouseIdException : WarehouseDomainException
{
    public InvalidWarehouseIdException() 
        : base("شناسه انبار نامعتبر است.", "Inventory.InvalidWarehouse") { }
}