using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine.Video;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IVideoClipLoader
    {
        VideoClip Load();
    }

    public interface IVideoClipLoader<in TKey>
    {
        VideoClip Load(TKey key);
    }

    public interface IIndexedVideoClipLoader
    {
        VideoClip Load(int index);
    }

    public interface IConditionalVideoClipLoader
    {
        VideoClip Load(Func<VideoClip, bool> predicate);
    }

    public interface IVideoClipsLoader
    {
        IEnumerable<VideoClip> Load();
    }

    public interface IVideoClipsLoader<in TKey>
    {
        IEnumerable<VideoClip> Load(TKey key);
    }

    public interface IIndexedVideoClipsLoader
    {
        IEnumerable<VideoClip> Load(int index);
    }

    public interface IConditionalVideoClipsLoader
    {
        IEnumerable<VideoClip> Load(Func<VideoClip, bool> predicate);
    }

    public interface IAsyncVideoClipLoader
    {
        UniTask<VideoClip> LoadAsync();
    }

    public interface IAsyncVideoClipLoader<in TKey>
    {
        UniTask<VideoClip> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedVideoClipLoader
    {
        UniTask<VideoClip> LoadAsync(int index);
    }

    public interface IAsyncConditionalVideoClipLoader
    {
        UniTask<VideoClip> LoadAsync(Func<VideoClip, bool> predicate);
    }

    public interface IAsyncVideoClipsLoader
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync();
    }

    public interface IAsyncVideoClipsLoader<in TKey>
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedVideoClipsLoader
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync(int index);
    }

    public interface IAsyncConditionalVideoClipsLoader
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync(Func<VideoClip, bool> predicate);
    }
}