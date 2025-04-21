using Newtonsoft.Json;

namespace BiliBiliComic.Responses;

public class BytesDataResponse<T> : ApiResponse<T>
{
    [JsonProperty("bytesData")] public string BytesData { get; set; }
}