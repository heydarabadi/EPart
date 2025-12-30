using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions.Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class StorageLocationAddressRequiredException : WarehouseDomainException
{
    public StorageLocationAddressRequiredException() 
        : base("آدرس جایگاه (Address) نمی‌تواند خالی باشد.", "Warehouse.AddressRequired") { }
}