using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine.Timeline;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface ITimelineAssetLoader
    {
        TimelineAsset Load();
    }

    public interface ITimelineAssetLoader<in TKey>
    {
        TimelineAsset Load(TKey key);
    }

    public interface IIndexedTimelineAssetLoader
    {
        TimelineAsset Load(int index);
    }

    public interface IConditionalTimelineAssetLoader
    {
        TimelineAsset Load(Func<TimelineAsset, bool> predicate);
    }

    public interface ITimelineAssetsLoader
    {
        IEnumerable<TimelineAsset> Load();
    }

    public interface ITimelineAssetsLoader<in TKey>
    {
        IEnumerable<TimelineAsset> Load(TKey key);
    }

    public interface IIndexedTimelineAssetsLoader
    {
        IEnumerable<TimelineAsset> Load(int index);
    }

    public interface IConditionalTimelineAssetsLoader
    {
        IEnumerable<TimelineAsset> Load(Func<TimelineAsset, bool> predicate);
    }

    public interface IAsyncTimelineAssetLoader
    {
        UniTask<TimelineAsset> LoadAsync();
    }

    public interface IAsyncTimelineAssetLoader<in TKey>
    {
        UniTask<TimelineAsset> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedTimelineAssetLoader
    {
        UniTask<TimelineAsset> LoadAsync(int index);
    }

    public interface IAsyncConditionalTimelineAssetLoader
    {
        UniTask<TimelineAsset> LoadAsync(Func<TimelineAsset, bool> predicate);
    }

    public interface IAsyncTimelineAssetsLoader
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync();
    }

    public interface IAsyncTimelineAssetsLoader<in TKey>
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedTimelineAssetsLoader
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync(int index);
    }

    public interface IAsyncConditionalTimelineAssetsLoader
    {
        UniTask<IEnumerable<TimelineAsset>> LoadAsync(Func<TimelineAsset, bool> predicate);
    }
}