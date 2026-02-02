using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public partial record WarehouseDeactivatedEvent(Guid WarehouseId) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}