using SpbDotNet_Nuget_Dtos;

namespace SpbDotNet_Nuget_Error
{
    public class Worker
    {
        public string DtoToString(NugetDto dto)
        {
            return $"{dto.Id.ToString()}-{dto.Name}-{dto.Description}";
        }
    }
}