using Newtonsoft.Json;

namespace BiliBiliComic.Responses;

public class ApiResponse<T>
{
    [JsonProperty("code")] public int Code { get; set; }

    [JsonProperty("msg")] public string Msg { get; set; }

    [JsonProperty("data")] public T Data { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}