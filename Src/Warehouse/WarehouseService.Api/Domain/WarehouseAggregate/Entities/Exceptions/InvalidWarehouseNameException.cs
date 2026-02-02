using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class InvalidWarehouseNameException : WarehouseDomainException
{
    public InvalidWarehouseNameException() 
        : base("نام انبار نامعتبر است یا نمی‌تواند خالی باشد.", "Warehouse.InvalidName") { }
}