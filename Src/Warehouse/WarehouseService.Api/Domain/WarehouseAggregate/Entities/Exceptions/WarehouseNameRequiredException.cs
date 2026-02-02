using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseNameRequiredException : WarehouseDomainException
{
    public WarehouseNameRequiredException() : base("نام انبار نمی‌تواند خالی باشد.", "Warehouse.NameRequired")
    {
    }
}