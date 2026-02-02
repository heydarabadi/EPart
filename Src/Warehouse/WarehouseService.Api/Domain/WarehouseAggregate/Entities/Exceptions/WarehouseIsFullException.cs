using WarehouseService.Api.Domain.WarehouseAggregate.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseIsFullException : WarehouseDomainException
{
    public WarehouseIsFullException() : base("ظرفیت انبار برای تعریف جایگاه جدید تکمیل است.", "Warehouse.Full")
    {
    }
}