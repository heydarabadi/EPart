using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

public record StockReservedEvent(
    string SKU, 
    Guid WarehouseId, 
    int Quantity, 
    string ReferenceId) : IDomainEvent
{
    public DateTime OccurredOn { get; }
}