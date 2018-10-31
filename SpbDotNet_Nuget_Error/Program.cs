using System;
using SpbDotNet_Nuget;

namespace SpbDotNet_Nuget_Error
{
    class Program
    {
        static void Main(string[] args)
        {
            var dto = new DataTransferObject
            {
                Id = Guid.NewGuid(),
                FirstName = "First",
                LastName = "LastName",
                Description = "Description of the first"
            };

            Console.WriteLine($"{dto.Id}-{dto.FirstName}-{dto.LastName}-{dto.Description}");
        }
    }
}