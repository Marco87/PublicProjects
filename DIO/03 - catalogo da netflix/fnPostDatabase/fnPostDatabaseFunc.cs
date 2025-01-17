using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace fnPostDatabase;

public class fnPostDatabaseFunc
{
    private readonly ILogger<fnPostDatabaseFunc> _logger;

    public fnPostDatabaseFunc(ILogger<fnPostDatabaseFunc> logger)
    {
        _logger = logger;
    }

    [Function("movie")]
    [CosmosDBOutput("%CosmosDBDatabaseName%", "%CosmosDBContainerName%", Connection = "CosmosDBConection", CreateIfNotExists = true, PartitionKey = "/id")]
    public async Task<Object?> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
    {
        _logger.LogInformation("Initiating movie function");
        MovieRequest? movie = null;
        try
        {
            var content = await new StreamReader(req.Body).ReadToEndAsync();
            movie = JsonConvert.DeserializeObject<MovieRequest>(content);
        }
        catch (Exception e)
        {
            _logger.LogError(e,"Error: {Message}", e.Message);
            return new BadRequestObjectResult($"Error: {e.Message}");
        }
        return JsonConvert.SerializeObject(movie);
    }

}