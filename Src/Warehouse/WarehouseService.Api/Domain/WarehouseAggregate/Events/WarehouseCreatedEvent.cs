using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record WarehouseCreatedEvent(Guid WarehouseId, string Name, int Capacity) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}