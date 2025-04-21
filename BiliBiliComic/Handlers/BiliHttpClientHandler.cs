namespace BiliBiliComic.Handlers;

public class BiliHttpClientHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/135.0.0.0 Safari/537.36 Edg/135.0.0.0");
        request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
        request.Headers.Add("Accept-Encoding", "gzip, deflate");
        request.Headers.Add("pragma", "no-cache");
        request.Headers.Add("cache-control", "no-cache");
        request.Headers.Add("sec-ch-ua", "\"Microsoft Edge\";v=\"135\", \"Not-A.Brand\";v=\"8\", \"Chromium\";v=\"135\"");
        request.Headers.Add("sec-ch-ua-mobile", "?0");
        request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
        request.Headers.Add("upgrade-insecure-requests", "1");
        request.Headers.Add("sec-fetch-site", "same-origin");
        request.Headers.Add("sec-fetch-mode", "navigate");
        request.Headers.Add("sec-fetch-user", "?1");
        request.Headers.Add("sec-fetch-dest", "document");
        request.Headers.Add("accept-language", "zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6");
        request.Headers.Add("priority", "u=0, i");
        var response = await base.SendAsync(request, cancellationToken);
        return response;

    }
}