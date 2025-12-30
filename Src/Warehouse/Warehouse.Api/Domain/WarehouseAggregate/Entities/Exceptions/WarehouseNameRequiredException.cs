namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class WarehouseNameRequiredException : WarehouseDomainException
{
    public WarehouseNameRequiredException() : base("نام انبار نمی‌تواند خالی باشد.", "Warehouse.NameRequired")
    {
    }
}