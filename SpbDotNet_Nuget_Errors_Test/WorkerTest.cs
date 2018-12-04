using System;
using SpbDotNet_Nuget_Dtos;
using Xunit;
using SpbDotNet_Nuget_Error;

namespace SpbDotNet_Nuget_Errors_Test
{
    public class WorkerTest
    {
        private readonly Worker _worker = new Worker();

        [Fact]
        public void DtoToString_Test()
        {
            var dto = new NugetDto
            {
                Id = Guid.NewGuid(),
                Name = "First",
                Description = "Description of the first"
            };

            Assert.Equal(_worker.DtoToString(dto), $"{dto.Id.ToString()}-{dto.Name}-{dto.Description}");
        }
    }
}