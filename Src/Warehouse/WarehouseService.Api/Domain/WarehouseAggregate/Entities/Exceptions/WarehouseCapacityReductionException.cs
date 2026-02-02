using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseCapacityReductionException : WarehouseDomainException
{
    public WarehouseCapacityReductionException() 
        : base("کاهش ناگهانی ظرفیت به بیش از ۵۰ درصد مجاز نیست.", "Warehouse.CapacityReductionLimit") { }
}