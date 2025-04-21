using System.Net;
using BiliBiliComic.Apis;
using BiliBiliComic.Handlers;
using Refit;

namespace BiliBiliComic;

public class BiliComicClient
{
    private const string BaseUrl = "https://apis.netstart.cn/bcomic";

    private HttpClient _httpClient = new(new BiliHttpClientHandler
    {
        InnerHandler = new HttpClientHandler()
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        }
    })
    {
        BaseAddress = new Uri(BaseUrl)
    };

    public IClassApi ClassApi { get; }
    public IComicApi ComicApi { get; }

    public BiliComicClient()
    {
        var settings = new RefitSettings
        {
            ContentSerializer = new NewtonsoftJsonContentSerializer(),
        };
        ClassApi = RestService.For<IClassApi>(_httpClient, settings);
        ComicApi = RestService.For<IComicApi>(_httpClient, settings);
    }
}