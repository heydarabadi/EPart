namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class WarehouseAlreadyDeactivatedException : WarehouseDomainException
{
    public WarehouseAlreadyDeactivatedException() : base("این انبار در حال حاضر غیرفعال است.",
        "Warehouse.AlreadyDeactivated")
    {
    }
}