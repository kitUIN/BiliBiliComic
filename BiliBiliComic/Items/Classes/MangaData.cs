using Newtonsoft.Json;

namespace BiliBiliComic.Item.Class;


public class MangaData
{
    [JsonProperty("season_id")]
    public int SeasonId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("horizontal_cover")]
    public string HorizontalCover { get; set; }

    [JsonProperty("square_cover")]
    public string SquareCover { get; set; }

    [JsonProperty("vertical_cover")]
    public string VerticalCover { get; set; }

    [JsonProperty("is_finish")]
    public int IsFinish { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("last_ord")]
    public double LastOrd { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }

    [JsonProperty("release_time")]
    public string ReleaseTime { get; set; }

    [JsonProperty("last_short_title")]
    public string LastShortTitle { get; set; }

    [JsonProperty("discount_type")]
    public int DiscountType { get; set; }

    [JsonProperty("allow_wait_free")]
    public bool AllowWaitFree { get; set; }

    [JsonProperty("type")]
    public int Type { get; set; }

    [JsonProperty("bottom_info")]
    public string BottomInfo { get; set; }

    [JsonProperty("bottom_info_v2")]
    public List<string> BottomInfoV2 { get; set; }

    [JsonProperty("styles")]
    public List<string> Styles { get; set; }

    [JsonProperty("rd_tag")]
    public string RdTag { get; set; }

    [JsonProperty("author")]
    public List<string> Author { get; set; }

    [JsonProperty("introduction")]
    public string Introduction { get; set; }

    [JsonProperty("evaluate")]
    public string Evaluate { get; set; }

    [JsonProperty("is_free")]
    public int IsFree { get; set; }
}