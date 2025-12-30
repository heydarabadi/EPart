namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class WarehouseAtCapacityException : WarehouseDomainException
{
    public WarehouseAtCapacityException() 
        : base("ظرفیت کل انبار تکمیل شده است و امکان پذیرش کالای جدید نیست.", "Warehouse.AtCapacity") { }
}