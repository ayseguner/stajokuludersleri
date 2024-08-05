using Core.Models.Response;

namespace DataAccess.Repositories.Abstract
{
    public interface IPlantRepository
    {
        Task<List<GetPlantInformationsResponseModel>> GetPlantInformationsAsync();
    }
}
