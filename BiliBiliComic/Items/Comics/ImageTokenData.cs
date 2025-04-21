using Newtonsoft.Json;

namespace BiliBiliComic.Items.Comics;

public class ImageTokenData
{
    /// <summary>
    /// 原始链接
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }

    /// <summary>
    /// token
    /// </summary>
    [JsonProperty("token")]
    public string Token { get; set; }

    /// <summary>
    /// 图片链接
    /// </summary>
    [JsonProperty("complete_url")]
    public string CompleteUrl { get; set; }

    [JsonProperty("hit_encrpyt")] public bool HitEncrypt { get; set; }

    [JsonProperty("biz_code")] public int BizCode { get; set; }
}