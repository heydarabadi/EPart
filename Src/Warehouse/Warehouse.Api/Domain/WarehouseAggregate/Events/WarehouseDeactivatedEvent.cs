using Shared.Domain;

namespace Warehouse.Api.Domain.WarehouseAggregate.Events;

public partial record WarehouseDeactivatedEvent(Guid WarehouseId) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}