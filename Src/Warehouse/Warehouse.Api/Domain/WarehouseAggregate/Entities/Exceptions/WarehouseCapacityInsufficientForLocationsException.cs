namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class WarehouseCapacityInsufficientForLocationsException : WarehouseDomainException
{
    public WarehouseCapacityInsufficientForLocationsException() : base(
        "ظرفیت جدید نمی‌تواند کمتر از تعداد جایگاه‌های فعلی باشد.", "Warehouse.CapacityInsufficient")
    {
    }
}