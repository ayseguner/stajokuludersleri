using Core.Models.Response;

namespace Core.Helpers.Abstract
{
    public interface IFlowersHelper
    {
        Task<List<GetFlowersInformationResponseDataModel>> GetFlowersInformationAsync();
    }
}
