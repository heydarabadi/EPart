namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

using Shared.Domain;

public class WarehouseDomainException : DomainException
{
    public WarehouseDomainException(string message) 
        : base(message, "WarehouseError") // کد پایه برای تمام خطاهای انبار
    {
    }

    protected WarehouseDomainException(string message, string code) 
        : base(message, code)
    {
    }
}