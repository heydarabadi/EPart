using DispatchR.Abstractions.Send;

namespace Shared.Application.CqrsConfig;

public interface ICommand<TRequest, TResponse> : IRequest<TRequest, TResponse> 
    where TRequest : class { }