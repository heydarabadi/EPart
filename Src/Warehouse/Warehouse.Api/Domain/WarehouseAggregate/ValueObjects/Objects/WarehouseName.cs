using Shared.Domain;
using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.ValueObjects;

public class WarehouseName : ValueObject
{
    public string Value { get; }

    private WarehouseName(string value)
    {
        // تمام قوانین اعتبارسنجی نام اینجا متمرکز می‌شود
        if (string.IsNullOrWhiteSpace(value))
            throw new WarehouseNameRequiredException();

        if (value.Length is < 3 or > 100)
            throw new InvalidWarehouseNameLengthException(value.Length);

        Value = value;
    }

    public static WarehouseName Create(string value) => new(value);

    // تبدیل ضمنی (Implicit Conversion) برای راحتی کار با رشته‌ها
    public static implicit operator string(WarehouseName name) => name.Value;
    
    public override string ToString() => Value;

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }
}