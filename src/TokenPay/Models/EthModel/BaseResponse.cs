using Newtonsoft.Json;

namespace TokenPay.Models.EthModel
{
    public class BaseResponseList<T>
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("result")]
        public List<T> Result { get; set; } = [];
    }
    public class BaseResponse<T>
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("result")]
        public T? Result { get; set; }
    }
}
