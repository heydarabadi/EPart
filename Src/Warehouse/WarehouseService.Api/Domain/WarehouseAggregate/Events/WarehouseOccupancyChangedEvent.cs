using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record WarehouseOccupancyChangedEvent(
    Guid WarehouseId, 
    int NewOccupiedAmount) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}