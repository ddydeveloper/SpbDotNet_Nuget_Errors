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
                FirtsName = "First",
                LastName = "LastName",
                Description = "Description of the first"
            };

            Console.WriteLine($"{dto.Id}-{dto.FirtsName}-{dto.LastName}-{dto.Description}");
        }
    }
}