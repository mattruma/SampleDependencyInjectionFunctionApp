using Microsoft.AspNetCore.Mvc;
using SampleDependencyInjectionFunctionApp.Data;
using System;
using Xunit;

namespace SampleDependencyInjectionFunctionApp.Tests
{
    public class Function3Tests :BaseTests
    {
        [Fact]
        public void Run_With_ToDoSample1DataStore()
        {
            // Arrange

            var toDo =
                new ToDo
                {
                    Description = $"description-{Guid.NewGuid()}"
                };

            var function3 =
                new Function3(
                    new ToDoSample1DataStore());

            // Act

            var actionResult = 
                function3.Run(toDo, _logger);

            // Assert

            Assert.IsType<OkObjectResult>(actionResult);

            var okObjectResult =
                (OkObjectResult)actionResult;

            Assert.IsType<ToDo>(okObjectResult.Value);

            toDo =
                (ToDo)okObjectResult.Value;

            var expectedDataStore =
                nameof(ToDoSample1DataStore);

            Assert.Equal(expectedDataStore, toDo.DataStore);
        }

        [Fact]
        public void Run_With_ToDoSample2DataStore()
        {
            // Arrange

            var toDo =
                new ToDo
                {
                    Description = $"description-{Guid.NewGuid()}"
                };

            var function3 =
                new Function3(
                    new ToDoSample2DataStore());

            // Act

            var actionResult = 
                function3.Run(toDo, _logger);

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
