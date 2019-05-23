using Microsoft.Extensions.Logging;

namespace SampleDependencyInjectionFunctionApp.Data
{
    public class ToDoSample1DataStore : IToDoDataStore
    {
        public ToDo Add(
            ToDo toDo,
            ILogger logger)
        {
            logger.LogInformation($"Adding ToDo using {nameof(ToDoSample1DataStore)}...");
            logger.LogInformation("ToDo added.");

            toDo.DataStore = nameof(ToDoSample1DataStore);

            return toDo;
        }
    }
}
