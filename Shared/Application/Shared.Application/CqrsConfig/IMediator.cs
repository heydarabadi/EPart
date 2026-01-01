using DispatchR.Abstractions.Send;

namespace Shared.Application.CqrsConfig;

public interface IMediator
{
    TResponse Send<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default) 
        where TRequest : class, IRequest<TRequest, TResponse>;
}