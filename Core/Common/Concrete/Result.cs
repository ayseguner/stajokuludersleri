using System.Net;
using System.Text.Json.Serialization;

namespace Core.Common.Concrete
{
    public class Result<T>
    {
        [JsonIgnore]
        public HttpStatusCode HttpStatusCode { get; set; }
        public string? InternalMessage { get; set; }
        public string? UserMessage { get; set; }
        public List<T>? Data { get; set; }
    }
}
