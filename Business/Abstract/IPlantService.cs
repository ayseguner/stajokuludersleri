using Core.Common.Concrete;
using Core.Models.Response;

namespace Business.Abstract
{
    public interface IPlantService
    {
        Task<ServiceResult<GetPlantInformationsResponseModel>> GetPlantInformationsAsync();
    }
}
