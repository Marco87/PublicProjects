using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services.AddSingleton(s =>
{
    string? connectionString = Environment.GetEnvironmentVariable("CosmosDBConnection");
    if(string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Please specify a valid CosmosDB connection string in the 'CosmosDBConection' environment variable.");
    }
    return new CosmosClient(connectionString);
});

await builder.Build().RunAsync();