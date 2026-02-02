using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseCapacityReductionLimitException : WarehouseDomainException
{
    public WarehouseCapacityReductionLimitException() : base("کاهش ظرفیت به بیش از ۵۰ درصد مجاز نیست.",
        "Warehouse.CapacityReductionLimit")
    {
    }
}