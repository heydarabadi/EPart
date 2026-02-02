using Shared.Application.CqrsConfig.Contracts;

namespace WarehouseService.Api.Application.WarehouseAggregate.Commands.Create;

public sealed class CreateWarehouseHandler : ICommandHandler<CreateWarehouseCommand, bool>
{
    public bool Handle(CreateWarehouseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}