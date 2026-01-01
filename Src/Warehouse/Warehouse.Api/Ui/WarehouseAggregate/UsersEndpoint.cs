
using DispatchR;
using DispatchR.Abstractions.Send;
using Shared.Application.CqrsConfig;
using Shared.Ui;
using IMediator = Shared.Application.CqrsConfig.IMediator;

namespace Warehouse.Api.Ui.WarehouseAggregate;

// در فایل UsersEndpoint.cs
public class UsersEndpoint : IEndpointDefinition
{
    public void DefineEndpoints(IEndpointRouteBuilder app)
    {
        app.MapGet("/users", async (IMediator _mediator) => await _mediator.Send<test, ValueTask<string>>(new test(),CancellationToken.None));
    }
}

public sealed record test:IQuery<test, ValueTask<string>>;

public sealed class testHandler() : IQueryHandler<test, ValueTask<string>>
{
    public async ValueTask<string> Handle(test request, CancellationToken cancellationToken)
    {
        return "pouya";
    }
}