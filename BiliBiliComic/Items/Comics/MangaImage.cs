using Newtonsoft.Json;

namespace BiliBiliComic.Items.Comics;

public class MangaImage
{
    [JsonProperty("path")]
    public string Path { get; set; }

    [JsonProperty("x")]
    public int Width { get; set; }

    [JsonProperty("y")]
    public int Height { get; set; }

    [JsonProperty("video_path")]
    public string VideoPath { get; set; }

    [JsonProperty("video_size")]
    public string VideoSize { get; set; }
}