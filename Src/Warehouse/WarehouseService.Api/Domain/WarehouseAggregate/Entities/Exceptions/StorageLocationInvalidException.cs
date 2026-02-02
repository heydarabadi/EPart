using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class StorageLocationInvalidException : WarehouseDomainException
{
    public StorageLocationInvalidException(string message) 
        : base(message, "Warehouse.InvalidStorageLocation") { }
}