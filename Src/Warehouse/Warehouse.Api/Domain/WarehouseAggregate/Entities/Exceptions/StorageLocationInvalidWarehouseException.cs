using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class StorageLocationInvalidWarehouseException : WarehouseDomainException
{
    public StorageLocationInvalidWarehouseException() 
        : base("شناسه انبار برای ایجاد جایگاه نامعتبر است.", "Warehouse.InvalidId") { }
}