using Shared.Domain;

namespace Warehouse.Api.Domain.WarehouseAggregate.Events;

public record StockShippedEvent(
    string SKU, 
    Guid WarehouseId, 
    int Quantity, 
    string OrderId) : IDomainEvent
{
    public DateTime OccurredOn { get; }
}