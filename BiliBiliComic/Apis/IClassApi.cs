using BiliBiliComic.Item.Class;
using BiliBiliComic.Responses;
using Refit;

namespace BiliBiliComic.Apis;

/// <summary>
/// 分类Api
/// </summary>
public interface IClassApi
{
    /// <summary>
    /// 分类筛选条件
    /// </summary>
    /// <returns></returns>
    [Get("/AllLabel")]
    Task<Responses.ApiResponse<LabelData>> AllLabel();

    /// <summary>
    /// 分类筛选结果列表
    /// </summary>
    /// <param name="styleId"></param>
    /// <param name="areaId"></param>
    /// <param name="isFinish"></param>
    /// <param name="order"></param>
    /// <param name="pageNum"></param>
    /// <param name="pageSize"></param>
    /// <param name="isFree"></param>
    [Get("/ClassPage")]
    Task<BytesDataResponse<List<MangaData>>> ClassPage(
        [Query] int? styleId = null,
        [Query] int? areaId = null,
        [Query] int? isFinish = null,
        [Query] int? order = null,
        [Query] int? pageNum = null,
        [Query] int? pageSize = null,
        [Query] int? isFree = null
    );
}