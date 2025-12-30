using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.Entities.Exceptions;

public class WarehouseNotActiveException : WarehouseDomainException
{
    public WarehouseNotActiveException() 
        : base("انبار غیرفعال است و امکان ثبت موجودی جدید در آن وجود ندارد.", "Warehouse.NotActive") { }
}