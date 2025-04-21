using BiliBiliComic.Apis;
using BiliBiliComic.Items.Comics;


namespace BiliBiliComic.Extensions;

public static class ComicApiExtension
{ 
    public static Task<Responses.ApiResponse<List<ImageTokenData>>> ImageToken(this IComicApi api, IList<string> urls)
    {
        return api.ImageToken($"[{string.Join(",", urls.Select(x => $"\"{x}\""))}]");
    }
}