
using Newtonsoft.Json;

namespace BiliBiliComic.Items.Comics;

public class ImageIndexData
{
    [JsonProperty("path")]
    public string Path { get; set; }

    [JsonProperty("images")]
    public List<MangaImage> Images { get; set; }

    [JsonProperty("host")]
    public string Host { get; set; }

    [JsonProperty("last_modified")]
    public string LastModified { get; set; }

    [JsonProperty("video")]
    public MangaVideo Video { get; set; }
}