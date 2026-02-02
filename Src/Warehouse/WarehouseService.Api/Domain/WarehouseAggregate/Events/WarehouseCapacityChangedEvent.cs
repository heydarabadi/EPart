using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record WarehouseCapacityChangedEvent(Guid WarehouseId, int NewCapacity) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}