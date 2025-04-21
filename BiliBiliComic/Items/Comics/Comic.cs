using Newtonsoft.Json;

namespace BiliBiliComic.Items.Comics;

public class ComicDetail
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("comic_type")]
    public int ComicType { get; set; }

    [JsonProperty("horizontal_cover")]
    public string HorizontalCover { get; set; }

    [JsonProperty("square_cover")]
    public string SquareCover { get; set; }

    [JsonProperty("vertical_cover")]
    public string VerticalCover { get; set; }

    [JsonProperty("author_name")]
    public List<string> AuthorName { get; set; }

    [JsonProperty("styles")]
    public List<string> Styles { get; set; }

    [JsonProperty("ep_list")]
    public List<Episode> Episodes { get; set; }

    [JsonProperty("evaluate")]
    public string Evaluate { get; set; }

    [JsonProperty("release_time")]
    public string ReleaseTime { get; set; }

    [JsonProperty("introduction")]
    public string Introduction { get; set; }

    [JsonProperty("authors")]
    public List<Author> Authors { get; set; }
}

public class Episode
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("ord")]
    public int Ord { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("cover")]
    public string Cover { get; set; }

    [JsonProperty("pub_time")]
    public string PubTime { get; set; }

    [JsonProperty("comments")]
    public int Comments { get; set; }

    [JsonProperty("like_count")]
    public int LikeCount { get; set; }

    [JsonProperty("image_count")]
    public int ImageCount { get; set; }
}

public class Author
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}