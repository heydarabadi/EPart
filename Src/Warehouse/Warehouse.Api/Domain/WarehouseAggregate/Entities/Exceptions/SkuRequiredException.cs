using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class SkuRequiredException : WarehouseDomainException
{
    public SkuRequiredException() : base("کد کالا (SKU) الزامی است.", "Inventory.SkuRequired") { }
}