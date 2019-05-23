using Microsoft.AspNetCore.Mvc;
using SampleDependencyInjectionFunctionApp.Data;
using System;
using Xunit;

namespace SampleDependencyInjectionFunctionApp.Tests
{
    public class Function2Tests :BaseTests
    {
        [Fact]
        public void Run()
        {
            // Arrange

            var toDo =
                new ToDo
                {
                    Description = $"description-{Guid.NewGuid()}"
                };

            // Act

            var actionResult = 
                Function2.Run(toDo, _logger);

            // Assert

            Assert.IsType<OkObjectResult>(actionResult);

            var okObjectResult =
                (OkObjectResult)actionResult;

            Assert.IsType<ToDo>(okObjectResult.Value);

            toDo =
                (ToDo)okObjectResult.Value;

            var expectedDataStore =
                nameof(ToDoSample2DataStore);

            Assert.Equal(expectedDataStore, toDo.DataStore);
        }
    }
}
