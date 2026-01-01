using System.Reflection;
using Shared.Application.DependencyInjections;
using Shared.Ui;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddUiSharedBuildServices(Assembly.GetExecutingAssembly());

builder.Services.AddCqrs(Assembly.GetExecutingAssembly());

var app = builder.Build();

string projectName = "Warehouse.Api";


app.MapOpenApi();
app.UseHttpsRedirection();

app.UseUiSharedBuildServices(projectName);

await app.RunAsync();