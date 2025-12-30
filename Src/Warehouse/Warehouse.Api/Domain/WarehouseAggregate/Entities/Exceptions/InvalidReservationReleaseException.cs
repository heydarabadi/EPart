namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InvalidReservationReleaseException : WarehouseDomainException
{
    public InvalidReservationReleaseException() 
        : base("مقدار آزادسازی نمی‌تواند بیشتر از مقدار رزرو شده فعلی باشد.", "Inventory.InvalidRelease") { }
}