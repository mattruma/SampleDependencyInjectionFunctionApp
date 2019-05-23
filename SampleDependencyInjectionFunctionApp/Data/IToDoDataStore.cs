using Microsoft.Extensions.Logging;

namespace SampleDependencyInjectionFunctionApp.Data
{
    public interface IToDoDataStore
    {
        ToDo Add(
            ToDo toDo,
            ILogger _logger);
    }
}
