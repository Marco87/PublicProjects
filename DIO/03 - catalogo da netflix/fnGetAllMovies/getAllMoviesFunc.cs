using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace fnGetAllMovies;

public class getAllMoviesFunc
{
    private readonly ILogger<getAllMoviesFunc> _logger;
    private readonly CosmosClient _cosmosClient;
    
    public getAllMoviesFunc(ILogger<getAllMoviesFunc> logger, CosmosClient cosmosClient)
    {
        _logger = logger;
        _cosmosClient = cosmosClient;
    }

    [Function("all")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        
        var container = _cosmosClient.GetContainer("DioFlixDb", "movies");

        var query = new QueryDefinition("SELECT * FROM c ");
        var result = container.GetItemQueryIterator<MovieResult>(query);
        var movies = new List<MovieResult>();
        while (result.HasMoreResults)
        {
            foreach (var item in await result.ReadNextAsync())
            {
                movies.Add(item);
            }
        }
        
        if (movies.Count == 0)
        {
            return new NotFoundResult();
        }
        return new OkObjectResult(movies);
        
    }

}