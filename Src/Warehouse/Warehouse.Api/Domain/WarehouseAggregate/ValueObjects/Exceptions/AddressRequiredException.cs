using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.ValueObjects.Exceptions;

// خطای خالی بودن آدرس
public class AddressRequiredException : WarehouseDomainException
{
    public AddressRequiredException() 
        : base("آدرس پستی انبار نمی‌تواند خالی باشد.", "Warehouse.AddressRequired") { }
}