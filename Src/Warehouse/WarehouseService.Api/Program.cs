using System.Reflection;
using Microsoft.Extensions.Options;
using Shared.Application.DependencyInjections;
using Shared.Infrastructure.OptionPatternConfiguration;
using Shared.Ui;
using WarehouseService.Api.Infrastructure.ApplicationOptions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddUiSharedBuildServices(Assembly.GetExecutingAssembly());

builder.Services.AddOptionsFromConfig<WarehouseOption>(builder.Configuration);



builder.Services.AddCqrs(Assembly.GetExecutingAssembly());

var app = builder.Build();

var scope = app.Services.CreateScope();
var options = scope.ServiceProvider.GetRequiredService<IOptions<WarehouseOption>>();




string projectName = "WarehouseService.Api";


app.UseHttpsRedirection();

app.UseUiSharedBuildServices(projectName);

await app.RunAsync();