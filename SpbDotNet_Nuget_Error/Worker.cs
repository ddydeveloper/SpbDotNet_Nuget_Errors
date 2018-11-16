using SpbDotNet_Nuget_Dto;

namespace SpbDotNet_Nuget_Error
{
    public class Worker
    {
        public string DtoToString(DataTransferObject dto)
        {
            return $"{dto.Id}-{dto.Name}-{dto.Description}";
        }
    }
}