using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseLocationRequiredException : WarehouseDomainException
{
    public WarehouseLocationRequiredException() 
        : base("ثبت موقعیت مکانی (Location) برای انبار الزامی است.", "Warehouse.LocationRequired") { }
}