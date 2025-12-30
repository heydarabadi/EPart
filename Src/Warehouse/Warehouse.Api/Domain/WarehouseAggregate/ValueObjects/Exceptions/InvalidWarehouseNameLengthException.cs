using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

public class InvalidWarehouseNameLengthException : WarehouseDomainException
{
    public InvalidWarehouseNameLengthException(int length) 
        : base($"طول نام انبار ({length}) نامعتبر است. باید بین ۳ تا ۱۰۰ کاراکتر باشد.", "Warehouse.InvalidNameLength") { }
}