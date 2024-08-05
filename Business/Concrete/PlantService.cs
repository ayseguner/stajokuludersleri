using Business.Abstract;
using Core.Common.Concrete;
using Core.Constants;
using Core.Helpers.Abstract;
using Core.Models.Response;
using DataAccess.Repositories.Abstract;
using System.Net;

namespace Business.Concrete
{
    public class PlantService : IPlantService
    {
        private readonly IPlantRepository _plantRepository;
        private readonly IFlowersHelper _flowersHelper;

        public PlantService(IPlantRepository plantRepository, IFlowersHelper flowersHelper)
        {
            _plantRepository = plantRepository;
            _flowersHelper = flowersHelper;
        }

        public async Task<ServiceResult<GetPlantInformationsResponseModel>> GetPlantInformationsAsync()
        {
            try
            {
                var response = await _plantRepository.GetPlantInformationsAsync();

                if (response == null)
                {
                    return new ServiceResult<GetPlantInformationsResponseModel>
                    {
                        HttpStatusCode = HttpStatusCode.NoContent
                    };
                }
                else
                {
                    var flowers = await _flowersHelper.GetFlowersInformationAsync();

                    return new ServiceResult<GetPlantInformationsResponseModel>
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        UserMessage = ResponseMessagesConstant.SUCCESS,
                        InternalMessage = ResponseMessagesConstant.SUCCESS,
                        Data = response,
                        Flowers = flowers
                    };
                }
            }
            catch (Exception exception)
            {
                return new ServiceResult<GetPlantInformationsResponseModel>
                {
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                    UserMessage = ResponseMessagesConstant.EXCEPTION,
                    InternalMessage = $"{exception.Message} {exception.InnerException}",
                };
            }
        }
    }
}
