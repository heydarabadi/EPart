using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class NegativeTotalStockException : WarehouseDomainException
{
    public NegativeTotalStockException() 
        : base("موجودی کل (OnHand) نمی‌تواند منفی شود.", "Inventory.NegativeTotalStock") { }
}