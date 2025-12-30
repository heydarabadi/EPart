using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseLocationRequiredException : WarehouseDomainException
{
    public WarehouseLocationRequiredException() 
        : base("ثبت موقعیت مکانی (Location) برای انبار الزامی است.", "Warehouse.LocationRequired") { }
}