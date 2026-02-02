using Shared.Domain;

namespace WarehouseService.Api.Domain.WarehouseAggregate.Events;

// ایونت جابجایی بین قفسه‌ها داخلی
public partial record InventoryLocationChangedEvent(
    Guid InventoryItemId, 
    string SKU, 
    Guid? OldLocationId, 
    Guid? NewLocationId) : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}