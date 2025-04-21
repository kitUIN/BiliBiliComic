using Newtonsoft.Json;

namespace BiliBiliComic.Items.Comics;

public class MangaVideo
{
    [JsonProperty("svid")]
    public string Svid { get; set; }

    [JsonProperty("filename")]
    public string Filename { get; set; }

    [JsonProperty("route")]
    public string Route { get; set; }

    [JsonProperty("resource")]
    public List<string> Resource { get; set; }

    [JsonProperty("raw_width")]
    public string RawWidth { get; set; }

    [JsonProperty("raw_height")]
    public string RawHeight { get; set; }

    [JsonProperty("raw_rotate")]
    public string RawRotate { get; set; }

    [JsonProperty("img_urls")]
    public List<string> ImageUrls { get; set; }

    [JsonProperty("bin_url")]
    public string BinUrl { get; set; }

    [JsonProperty("img_x_len")]
    public int ImgXLen { get; set; }

    [JsonProperty("img_x_size")]
    public int ImgXSize { get; set; }

    [JsonProperty("img_y_len")]
    public int ImgYLen { get; set; }

    [JsonProperty("img_y_size")]
    public int ImgYSize { get; set; }
}