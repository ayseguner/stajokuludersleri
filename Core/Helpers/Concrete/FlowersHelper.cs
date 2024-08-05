using Core.Helpers.Abstract;
using Core.Models.Response;
using System.Text.Json;

namespace Core.Helpers.Concrete
{
    public class FlowersHelper : IFlowersHelper
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FlowersHelper(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<GetFlowersInformationResponseDataModel>> GetFlowersInformationAsync()
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                HttpContent content = new StringContent("application/json");
                var response = await client.GetAsync(new Uri($"https://localhost:7273/Flowers/information"));

                if (response.IsSuccessStatusCode)
                {
                    var deserializedStream = await JsonSerializer.DeserializeAsync<GetFlowersInformationResponseModel>(response.Content.ReadAsStream(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    return deserializedStream.data;
                }
                return new List<GetFlowersInformationResponseDataModel>();
            }
        }
    }
}
