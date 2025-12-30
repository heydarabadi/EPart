using Shared.Domain;

namespace Warehouse.Api.Domain.WarehouseAggregate.Events;

public record StockReservedEvent(
    string SKU, 
    Guid WarehouseId, 
    int Quantity, 
    string ReferenceId) : IDomainEvent
{
    public DateTime OccurredOn { get; }
}