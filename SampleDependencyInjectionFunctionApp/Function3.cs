using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SampleDependencyInjectionFunctionApp.Data;

namespace SampleDependencyInjectionFunctionApp
{
    public class Function3
    {
        private readonly IToDoDataStore _toDoDataStore;
        public Function3(
            IToDoDataStore toDoDataStore)
        {
            _toDoDataStore = toDoDataStore;
        }

        [FunctionName("Function3")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] ToDo toDo,
            ILogger logger)
        {
            logger.LogInformation("Function3 function processed a request.");

            if (toDo == null)
            {
                return new BadRequestResult();
            }

            toDo =
                _toDoDataStore.Add(
                    toDo,
                    logger);

            return new OkObjectResult(toDo);
        }
    }
}
