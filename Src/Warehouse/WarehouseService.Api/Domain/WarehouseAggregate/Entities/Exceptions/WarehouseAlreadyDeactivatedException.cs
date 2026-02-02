using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseAlreadyDeactivatedException : WarehouseDomainException
{
    public WarehouseAlreadyDeactivatedException() : base("این انبار در حال حاضر غیرفعال است.",
        "Warehouse.AlreadyDeactivated")
    {
    }
}