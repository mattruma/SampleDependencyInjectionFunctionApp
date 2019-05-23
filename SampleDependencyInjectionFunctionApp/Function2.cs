using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SampleDependencyInjectionFunctionApp.Data;

namespace SampleDependencyInjectionFunctionApp
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] ToDo toDo,
            ILogger logger)
        {
            logger.LogInformation("Function2 function processed a request.");

            if (toDo == null)
            {
                return new BadRequestResult();
            }

            var toDoDataStore =
                new ToDoSample2DataStore();

            toDo =
                toDoDataStore.Add(
                    toDo,
                    logger);

            return new OkObjectResult(toDo);
        }
    }
}
