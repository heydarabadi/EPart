using Shared.Application.CqrsConfig.Contracts;
using WarehouseService.Api.Application.WarehouseAggregate.Commands.Dto;

namespace WarehouseService.Api.Application.WarehouseAggregate.Commands.Create;

public sealed class CreateWarehouseCommand(string Name, int Capacity, bool IsActive, LocationDto Location) : ICommand<CreateWarehouseCommand, bool>;