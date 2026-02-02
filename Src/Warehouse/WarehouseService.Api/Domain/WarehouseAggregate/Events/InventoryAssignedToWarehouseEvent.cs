using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record InventoryAssignedToWarehouseEvent(Guid WarehouseId, string SKU, decimal Quantity=0) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}