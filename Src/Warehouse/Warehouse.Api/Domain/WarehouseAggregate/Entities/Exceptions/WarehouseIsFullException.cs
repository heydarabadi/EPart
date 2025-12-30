namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class WarehouseIsFullException : WarehouseDomainException
{
    public WarehouseIsFullException() : base("ظرفیت انبار برای تعریف جایگاه جدید تکمیل است.", "Warehouse.Full")
    {
    }
}