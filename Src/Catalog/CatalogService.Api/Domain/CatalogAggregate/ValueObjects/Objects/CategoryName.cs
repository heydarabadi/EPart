using Shared.Domain;

namespace CatalogService.Api.Domain.CatalogAggregate.ValueObjects.Objects;

public class CategoryName: ValueObject
{
    public string Value { get;private set; }

    private CategoryName()
    {
        
    }
    private CategoryName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(value));
        }

        if (value.Length > 100 || value.Length < 3)
        {
            throw new ArgumentException("Value must be between 3 and 100 characters long.", nameof(value));
        }
        Value = value;
    }

    public override string ToString() => Value;
    
    public static implicit operator string(CategoryName categoryName) => categoryName.Value;
    public static CategoryName Create(string value)
    {
        CategoryName categoryName = new CategoryName(value);
        return categoryName;
    }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }
}