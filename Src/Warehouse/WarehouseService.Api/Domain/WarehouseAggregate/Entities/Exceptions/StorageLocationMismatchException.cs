using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class StorageLocationMismatchException : WarehouseDomainException
{
    public StorageLocationMismatchException() 
        : base("جایگاه فیزیکی انتخاب شده متعلق به این انبار نیست.", "Inventory.LocationMismatch") { }
}