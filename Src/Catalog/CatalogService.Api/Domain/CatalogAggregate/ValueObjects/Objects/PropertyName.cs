using Shared.Domain;

namespace CatalogService.Api.Domain.CatalogAggregate.ValueObjects.Objects;

public class PropertyName : ValueObject
{
    public string Value { get; init; }
    private PropertyName()
    {
        
    }
    private PropertyName(string value)
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
    public static PropertyName Create(string value)
    {
        PropertyName propertyName = new PropertyName(value);
        return propertyName;
    }
    public override string ToString() => Value;
    public static implicit operator string(PropertyName propertyName) => propertyName.Value;
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }
}