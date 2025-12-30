namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class StorageLocationMismatchException : WarehouseDomainException
{
    public StorageLocationMismatchException() 
        : base("جایگاه فیزیکی انتخاب شده متعلق به این انبار نیست.", "Inventory.LocationMismatch") { }
}