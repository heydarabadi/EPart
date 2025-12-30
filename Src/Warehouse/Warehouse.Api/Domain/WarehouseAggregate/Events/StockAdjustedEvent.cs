using Shared.Domain;

namespace Warehouse.Api.Domain.WarehouseAggregate.Events;

public record StockAdjustedEvent(
    string SKU, 
    int NewQuantity, 
    string Reason) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;}