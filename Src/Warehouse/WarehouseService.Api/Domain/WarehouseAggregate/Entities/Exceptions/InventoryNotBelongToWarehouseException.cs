using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class InventoryNotBelongToWarehouseException : WarehouseDomainException
{
    public InventoryNotBelongToWarehouseException() 
        : base("این کالا متعلق به این انبار نیست.", "Warehouse.InventoryMismatch") { }
}