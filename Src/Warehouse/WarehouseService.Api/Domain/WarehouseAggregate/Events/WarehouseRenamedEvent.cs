using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record WarehouseRenamedEvent(Guid WarehouseId, string NewName) : IDomainEvent
{
    public DateTime OccurredOn { get; }
}