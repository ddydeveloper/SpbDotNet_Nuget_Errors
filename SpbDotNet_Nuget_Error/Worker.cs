using SpbDotNet_Nuget_Dtos;

namespace SpbDotNet_Nuget_Error
{
    public class Worker
    {
        public static string DtoToString(Person dto)
        {
            return $"{dto.FullName}, {dto.BirthDate}";
        }
    }
}