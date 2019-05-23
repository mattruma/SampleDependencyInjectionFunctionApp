using Microsoft.Extensions.Logging;

namespace SampleDependencyInjectionFunctionApp.Data
{
    public class ToDoSample2DataStore : IToDoDataStore
    {
        public ToDo Add(
            ToDo toDo,
            ILogger logger)
        {
            logger.LogInformation($"Adding ToDo using {nameof(ToDoSample2DataStore)}...");
            logger.LogInformation("ToDo added.");

            toDo.DataStore = nameof(ToDoSample2DataStore);

            return toDo;
        }
    }
}
