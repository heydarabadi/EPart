using Shared.Domain;

namespace CatalogService.Api.Domain.CatalogAggregate.ValueObjects.Objects;

public class CatalogName : ValueObject
{
    public string Value { get; init; }

    private CatalogName()
    {
        
    }
    
    private CatalogName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(nameof(value));
        }

        if (value.Length < 3 || value.Length > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(value));
        }
        Value = value;
    }

    public override string ToString() => Value;
    public static explicit operator string(CatalogName catalogName) => catalogName.ToString();

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }
}