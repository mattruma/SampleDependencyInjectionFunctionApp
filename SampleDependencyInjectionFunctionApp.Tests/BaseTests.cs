using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace SampleDependencyInjectionFunctionApp.Tests
{
    public abstract class BaseTests
    {
        protected readonly ILogger _logger;

        public BaseTests()
        {
            _logger =
                NullLoggerFactory.Instance.CreateLogger("Null Logger");
        }
    }
}
