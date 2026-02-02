using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class InvalidStorageLocationIdException : WarehouseDomainException
{
    public InvalidStorageLocationIdException() 
        : base("شناسه جایگاه فیزیکی (Storage Location) نامعتبر است.", "Inventory.InvalidLocation") { }
}