using Shared.Domain;

namespace Warehouse.Api.Domain.WarehouseAggregate.Events;

public record StockReceivedEvent(
    string SKU, 
    Guid WarehouseId, 
    int Quantity) : IDomainEvent
{
    public DateTime OccurredOn { get; }
}