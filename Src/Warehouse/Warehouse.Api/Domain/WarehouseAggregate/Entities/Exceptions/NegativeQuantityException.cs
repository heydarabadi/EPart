namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class NegativeQuantityException : WarehouseDomainException
{
    public NegativeQuantityException() 
        : base("مقدار عملیات موجودی باید عددی مثبت باشد.", "Inventory.NegativeQuantity") { }
}