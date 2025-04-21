using BiliBiliComic.Items.Comics;
using BiliBiliComic.Responses;
using Refit;

namespace BiliBiliComic.Apis;

public interface IComicApi
{
    /// <summary>
    /// 获取漫画详情和章节列表
    /// </summary>
    /// <param name="comicId">漫画 ID，必填</param>
    /// <returns>返回漫画详情</returns>
    [Get("/ComicDetail")]
    Task<BytesDataResponse<ComicDetail>> ComicDetail([Query] int comicId);
    
    /// <summary>
    /// 获取漫画章节内容图片索引
    /// </summary>
    /// <param name="epId">章节 ID，必填</param>
    /// <returns>返回图片索引数据</returns>
    [Get("/GetImageIndex")]
    Task<Responses.ApiResponse<ImageIndexData>> GetImageIndex([Query] int epId);

    
    /// <summary>
    /// 获取漫画图片 Token
    /// </summary>
    /// <param name="urls">图片 URL 数组，必填</param>
    /// <returns>返回图片 Token 数据</returns>
    [Get("/ImageToken")]
    Task<Responses.ApiResponse<List<ImageTokenData>>> ImageToken([Query] string urls);
}