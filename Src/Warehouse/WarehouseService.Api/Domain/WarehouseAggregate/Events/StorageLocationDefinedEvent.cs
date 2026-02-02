using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record StorageLocationDefinedEvent(
    Guid WarehouseId, 
    Guid LocationId, 
    string FullAddress) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}