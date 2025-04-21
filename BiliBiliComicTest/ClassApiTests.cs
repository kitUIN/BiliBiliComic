using BiliBiliComic;

namespace BiliBiliComicTest;

public class ClassApiTests
{
    private BiliComicClient _biliComicClient;

    [SetUp]
    public void Setup()
    {
        _biliComicClient = new BiliComicClient();
    }

    [Test]
    public async Task AllLabel()
    {
        var labelRes = await _biliComicClient.ClassApi.AllLabel();
        Console.WriteLine(labelRes.ToString());
        Assert.That(labelRes.Code, Is.EqualTo(0));
    }

    [Test]
    public async Task ClassPage()
    {
        var labelRes = await _biliComicClient.ClassApi.ClassPage();
        Console.WriteLine(labelRes.ToString());
        Assert.That(labelRes.Code, Is.EqualTo(0));
    }
}