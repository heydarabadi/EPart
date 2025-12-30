namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InvalidStorageLocationIdException : WarehouseDomainException
{
    public InvalidStorageLocationIdException() 
        : base("شناسه جایگاه فیزیکی (Storage Location) نامعتبر است.", "Inventory.InvalidLocation") { }
}