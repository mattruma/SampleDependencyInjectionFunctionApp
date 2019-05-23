using System;
using System.ComponentModel.DataAnnotations;

namespace SampleDependencyInjectionFunctionApp.Data
{
    public class ToDo
    {
        [Required]
        public string Id { get; set; }

        public string DataStore { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public ToDo()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
        }
    }
}
