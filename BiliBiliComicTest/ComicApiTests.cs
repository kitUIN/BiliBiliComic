using BiliBiliComic;
using BiliBiliComic.Extensions;
namespace BiliBiliComicTest;

[TestFixture]
public class ComicApiTests
{
    private BiliComicClient _biliComicClient;

    [SetUp]
    public void Setup()
    {
        _biliComicClient = new BiliComicClient();
    }

    [Test]
    public async Task ComicDetail()
    {
        var labelRes = await _biliComicClient.ComicApi.ComicDetail(31033);
        Console.WriteLine(labelRes.ToString());
        Assert.That(labelRes.Code, Is.EqualTo(0));
    }
    [Test]
    public async Task GetImageIndex()
    {
        var labelRes = await _biliComicClient.ComicApi.GetImageIndex(664941);
        Console.WriteLine(labelRes.ToString());
        Assert.That(labelRes.Code, Is.EqualTo(0));
    }
    [Test]
    public async Task ImageToken()
    {
        var labelRes = await _biliComicClient.ComicApi.ImageToken([
            "https://manga.hdslb.com/bfs/mangav4.local.aCNHjTbGOn6hOakg6ivT6ndzxqao72tPO1dVUiNbc6NAhQOyf3ydJ-fF-vc5yYb8UOszpmQUoijYYI_XFOpVlMLL0-lBpWDFnQ0lbrIEUQHyJ8NCJeQ67qrkIDulXHJLyxAz0i9zWGOu4lGEEOv5MFTydSQ5o4rus8PergIQcA702nr6uGJebXOoYKGPbZlXBVgwL9ZDKlaqEEO7QWiiHFgibmNT76uzqtkPGgq6ja-LWTvJU8lj2I1nzDGjNTobhEbyAD_cORKL2przC-iwZKdMwD86VGnBYY84LUkqqypfp75BXCJwmagoZppWWAFx-GhUyA2ftK-kKmisreHOMdLXbuTkC8bGWulAFJSPfe9D231dQd5ZQm05cDJ9sgLnPLKjiZvZJ770GNE/d46e7899618d869f9d31095d4dd50d072f2200f5.jpg@1000w.webp",
            "https://manga.hdslb.com/bfs/mangav4.local.aCNHjTbGOn6hOakg6ivT6ndzxqao72tPO1dVUiNbc6NAhQOyf3ydJ-fF-vc5yYb8UOszpmQUoijYYI_XFOpVlMLL0-lBpWDFnQ0lbrIEUQHyJ8NCJeQ67qrkIDulXHJLyxAz0i9zWGOu4lGEEOv5MFTydSQ5o4rus8PergIQcA702nr6uGJebXOoYKGPbZlXBVgwL9ZDKlaqEEO7QWiiHFgibmNT76uzqtkPGgq6ja-LWTvJU8lj2I1nzDGjNTobhEbyAD_cORKL2przC-iwZKdMwD86VGnBYY84LUkqqypfp75BXCJwmagoZppWWAFx-GhUyA2ftK-kKmisreHOMdLXbuTkC8bGWulAFJSPfe9D231dQd5ZQm05cDJ9sgLnPLKjiZvZJ770GNE/d46e7899618d869f9d31095d4dd50d072f2200f5.jpg@660w.webp"
        ]);
        Console.WriteLine(labelRes.ToString());
        Assert.That(labelRes.Code, Is.EqualTo(0));
    }
    
}