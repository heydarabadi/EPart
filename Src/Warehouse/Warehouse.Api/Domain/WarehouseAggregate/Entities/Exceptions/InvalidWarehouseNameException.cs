using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class InvalidWarehouseNameException : WarehouseDomainException
{
    public InvalidWarehouseNameException() 
        : base("نام انبار نامعتبر است یا نمی‌تواند خالی باشد.", "Warehouse.InvalidName") { }
}