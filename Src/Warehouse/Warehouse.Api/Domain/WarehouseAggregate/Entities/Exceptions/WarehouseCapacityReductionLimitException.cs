namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class WarehouseCapacityReductionLimitException : WarehouseDomainException
{
    public WarehouseCapacityReductionLimitException() : base("کاهش ظرفیت به بیش از ۵۰ درصد مجاز نیست.",
        "Warehouse.CapacityReductionLimit")
    {
    }
}