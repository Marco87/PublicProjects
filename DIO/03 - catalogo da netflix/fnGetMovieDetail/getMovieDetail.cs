using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json.Linq;

namespace fnGetMovieDetail;

public class getMovieDetail
{
    private readonly ILogger<getMovieDetail> _logger;
    private readonly CosmosClient _cosmosClient;

    public getMovieDetail(ILogger<getMovieDetail> logger, CosmosClient cosmosClient)
    {
        _logger = logger;
        _cosmosClient = cosmosClient;
    }
   
    [Function("detail")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        
        var container = _cosmosClient.GetContainer("DioFlixDb", "movies");
        var id = req.Query["id"];
        var query = new QueryDefinition("SELECT * FROM c WHERE c.id = @id")
            .WithParameter("@id", id.ToString().Trim());
        var result = container.GetItemQueryIterator<MovieResult>(query);
        var results = new List<MovieResult>();
        while (result.HasMoreResults)
        {
            foreach (var item in await result.ReadNextAsync())
            {
                results.Add(item);
            }
        }
        
        var movie = results.FirstOrDefault();
        if (movie == null)
        {
            return new NotFoundResult();
        }
        return new OkObjectResult(movie);
        
    }

}