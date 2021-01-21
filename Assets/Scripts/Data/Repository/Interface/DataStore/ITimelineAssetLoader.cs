using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine.Timeline;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface ITimelineAssetLoader
    {
        TimelineAsset Load();
    }

    public interface ITimelineAssetsLoader
    {
        IEnumerable<TimelineAsset> Load();
    }

    public interface IAsyncTimelineAssetLoader
    {
        UniTask<TimelineAsset> LoadAsync();
    }

    public interface IAsyncTimelineAssetsLoader
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedTimelineAssetLoader
    {
        TimelineAsset Load(int index);
    }

    public interface IIndexedTimelineAssetsLoader
    {
        IEnumerable<TimelineAsset> Load(int index);
    }

    public interface IAsyncIndexedTimelineAssetLoader
    {
        UniTask<TimelineAsset> LoadAsync(int index);
    }

    public interface IAsyncIndexedTimelineAssetsLoader
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalTimelineAssetLoader
    {
        TimelineAsset Load();
    }

    public interface IConditionalTimelineAssetsLoader
    {
        IEnumerable<TimelineAsset> Load();
    }

    public interface IAsyncConditionalTimelineAssetLoader
    {
        UniTask<TimelineAsset> LoadAsync();
    }

    public interface IAsyncConditionalTimelineAssetsLoader
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalTimelineAssetLoader<in TParam1>
    {
        TimelineAsset Load(TParam1 param1);
    }

    public interface IConditionalTimelineAssetsLoader<in TParam1>
    {
        IEnumerable<TimelineAsset> Load(TParam1 param1);
    }

    public interface IAsyncConditionalTimelineAssetLoader<in TParam1>
    {
        UniTask<TimelineAsset> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalTimelineAssetsLoader<in TParam1>
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync(TParam1 param1);
    }

    #endregion
}