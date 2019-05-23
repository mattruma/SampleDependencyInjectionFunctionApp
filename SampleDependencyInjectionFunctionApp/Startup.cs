using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SampleDependencyInjectionFunctionApp.Data;

// https://docs.microsoft.com/en-us/azure/azure-functions/functions-dotnet-dependency-injection

[assembly: FunctionsStartup(typeof(SampleDependencyInjectionFunctionApp.Startup))]
namespace SampleDependencyInjectionFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient<IToDoDataStore, ToDoSample1DataStore>();

            // TODO: Uncomment the below, and comment the above to use ToDoSample2DataStore as the default implement of IToDoDataStore
            // builder.Services.AddTransient<IToDoDataStore, ToDoSample2DataStore>();
        }
    }
}