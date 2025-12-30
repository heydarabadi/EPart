using Shared.Domain;

namespace Warehouse.Api.Domain.WarehouseAggregate.Events;

public record WarehouseOccupancyChangedEvent(
    Guid WarehouseId, 
    int NewOccupiedAmount) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}