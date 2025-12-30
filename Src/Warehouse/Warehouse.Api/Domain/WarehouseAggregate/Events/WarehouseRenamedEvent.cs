using Shared.Domain;

namespace Warehouse.Api.Domain.WarehouseAggregate.Events;

public record WarehouseRenamedEvent(Guid WarehouseId, string NewName) : IDomainEvent
{
    public DateTime OccurredOn { get; }
}