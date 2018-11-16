using System;

namespace SpbDotNet_Nuget_Dtos
{
    public class NugetDto
    {
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }
    }
}