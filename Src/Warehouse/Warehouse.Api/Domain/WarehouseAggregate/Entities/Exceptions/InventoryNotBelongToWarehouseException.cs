namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InventoryNotBelongToWarehouseException : WarehouseDomainException
{
    public InventoryNotBelongToWarehouseException() 
        : base("این کالا متعلق به این انبار نیست.", "Warehouse.InventoryMismatch") { }
}