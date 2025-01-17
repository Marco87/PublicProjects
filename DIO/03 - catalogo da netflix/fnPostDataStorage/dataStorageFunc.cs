using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fnPostDataStorage;

public class dataStorageFunc
{
    private readonly ILogger<dataStorageFunc> _logger;

    public dataStorageFunc(ILogger<dataStorageFunc> logger)
    {
        _logger = logger;
    }

    [Function("dataStorage")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
    {
        _logger.LogInformation("Processing images requests.");
        try
        {
            if(!req.Headers.TryGetValue("file-type", out var fileType))
            {
                return new BadRequestObjectResult("Please provide a file type in the header.");
            }
            
            var fileTypeValue = fileType.ToString();
            var form = await req.ReadFormAsync();
            var file = form.Files["file"];
            
            if (file == null || file.Length == 0)
            {
                return new BadRequestObjectResult("Please provide a file in the request.");
            }
            string connectionString = Environment.GetEnvironmentVariable("AzureWebJobsStorage");
            var containerName = fileTypeValue;
            
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);
            
            await containerClient.CreateIfNotExistsAsync();
            await containerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);

            string blobName = file.FileName;
            var blob = containerClient.GetBlobClient(blobName);

            await using var stream = file.OpenReadStream();
            await blob.UploadAsync(stream, true);
            
            _logger.LogInformation($"File {file.FileName} uploaded to {containerName} container.");

            return new OkObjectResult(new
            {
                Message = $"File {file.FileName} uploaded to {containerName} container.",
                BlobUri = blob.Uri
            });
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while processing the request.");
            return new BadRequestObjectResult("An error occurred while processing the request.");
        }
    }

}