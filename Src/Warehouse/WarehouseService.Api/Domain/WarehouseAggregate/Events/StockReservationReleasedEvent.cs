using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record StockReservationReleasedEvent(
    string SKU, 
    Guid WarehouseId, 
    int Quantity) : IDomainEvent
{
    public DateTime OccurredOn { get; }
}