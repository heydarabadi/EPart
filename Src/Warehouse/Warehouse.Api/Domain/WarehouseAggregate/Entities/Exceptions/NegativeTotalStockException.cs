namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class NegativeTotalStockException : WarehouseDomainException
{
    public NegativeTotalStockException() 
        : base("موجودی کل (OnHand) نمی‌تواند منفی شود.", "Inventory.NegativeTotalStock") { }
}