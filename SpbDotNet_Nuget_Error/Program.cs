using System;
using SpbDotNet_Nuget;

namespace SpbDotNet_Nuget_Error
{
    class Program
    {
        static void Main(string[] args)
        {
            var dto = new DataTransferObject {Id = 1, Name = "First", Description = "Description of the first"};
            Console.WriteLine($"{dto.Id}-{dto.Name}-{dto.Description}");
        }
    }
}