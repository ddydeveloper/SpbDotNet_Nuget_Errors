using System;
using SpbDotNet_Nuget_Dtos;
using Xunit;
using SpbDotNet_Nuget_Error;

namespace SpbDotNet_Nuget_Errors_Test
{
    public class WorkerTest
    {
        [Fact]
        public void DtoToString_Test()
        {
            var dto = new Person()
            {
                FullName = "John Doe",
                BirthDate = new DateTime(1991, 1, 1)
            };

            Assert.Equal(Worker.DtoToString(dto), $"{dto.FullName}, {dto.BirthDate}");
        }
    }
}