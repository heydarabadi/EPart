using Shared.Domain;
using WarehouseService.Api.Domain.WarehouseAggregate.ValueObjects.Exceptions;

namespace WarehouseService.Api.Domain.WarehouseAggregate.ValueObjects.Objects;

public class Location : ValueObject
{
    public string Address { get; }
    public double Latitude { get; }
    public double Longitude { get; }

    // ۱. Constructor با قابلیت اعتبارسنجی دقیق
    private Location(string address, double lat, double lon)
    {
        // بررسی آدرس
        if (string.IsNullOrWhiteSpace(address))
            throw new AddressRequiredException();

        // بررسی محدوده جغرافیایی استاندارد
        if (lat is < -90 or > 90 || lon is < -180 or > 180)
            throw new InvalidCoordinatesException(lat, lon);

        Address = address;
        Latitude = lat;
        Longitude = lon;
    }

    // ۲. Factory Method (اختیاری - برای خوانایی بیشتر)
    public static Location Create(string address, double lat, double lon) 
        => new(address, lat, lon);

    // ۳. متد کمکی برای نمایش متنی (مانند آدرس کامل)
    public override string ToString() => $"{Address} ({Latitude}, {Longitude})";

    // ۴. الزامی برای Value Object جهت مقایسه مقداری به جای ارجاعی
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Address.ToLowerInvariant(); // حساس نبودن به حروف کوچک و بزرگ در مقایسه
        yield return Latitude;
        yield return Longitude;
    }
}