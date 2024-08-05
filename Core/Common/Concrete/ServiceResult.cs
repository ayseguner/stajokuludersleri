using Core.Models.Response;

namespace Core.Common.Concrete
{
    public class ServiceResult<T> : Result<T>
    {
        public List<GetFlowersInformationResponseDataModel> Flowers { get; set; }
    }
}
