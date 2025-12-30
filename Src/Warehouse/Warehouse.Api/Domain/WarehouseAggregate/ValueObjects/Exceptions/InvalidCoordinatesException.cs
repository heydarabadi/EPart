using Warehouse.Api.Domain.WarehouseAggregate.Exceptions;

namespace Warehouse.Api.Domain.WarehouseAggregate.ValueObjects.Exceptions;

public class InvalidCoordinatesException : WarehouseDomainException
{
    public InvalidCoordinatesException(double lat, double lon) 
        : base($"مختصات جغرافیایی نامعتبر است. (Lat: {lat}, Lon: {lon})", "Warehouse.InvalidCoordinates") { }
}