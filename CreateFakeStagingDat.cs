using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace My.Functions
{
    public class CreateFakeStagingDat
    {
        private readonly ILogger<CreateFakeStagingDat> _logger;

        public CreateFakeStagingDat(ILogger<CreateFakeStagingDat> logger)
        {
            _logger = logger;
        }

        [Function("CreateFakeStagingDat")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
