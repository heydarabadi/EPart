using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class StorageLocationInvalidException : WarehouseDomainException
{
    public StorageLocationInvalidException(string message) 
        : base(message, "Warehouse.InvalidStorageLocation") { }
}