namespace Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class DuplicateStorageLocationException : WarehouseDomainException
{
    // تغییر سازنده برای پذیرش ۳ پارامتر
    public DuplicateStorageLocationException(string zone, string shelf, string bin) 
        : base($"جایگاه '{zone}-{shelf}-{bin}' قبلاً در این انبار تعریف شده است.", "Warehouse.DuplicateLocation") { }
}