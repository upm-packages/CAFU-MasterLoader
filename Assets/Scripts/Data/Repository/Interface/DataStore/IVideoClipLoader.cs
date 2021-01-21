using System.Collections.Generic;
using UniRx.Async;
using UnityEngine.Video;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IVideoClipLoader
    {
        VideoClip Load();
    }

    public interface IVideoClipsLoader
    {
        IEnumerable<VideoClip> Load();
    }

    public interface IAsyncVideoClipLoader
    {
        UniTask<VideoClip> LoadAsync();
    }

    public interface IAsyncVideoClipsLoader
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedVideoClipLoader
    {
        VideoClip Load(int index);
    }

    public interface IIndexedVideoClipsLoader
    {
        IEnumerable<VideoClip> Load(int index);
    }

    public interface IAsyncIndexedVideoClipLoader
    {
        UniTask<VideoClip> LoadAsync(int index);
    }

    public interface IAsyncIndexedVideoClipsLoader
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalVideoClipLoader
    {
        VideoClip Load();
    }

    public interface IConditionalVideoClipsLoader
    {
        IEnumerable<VideoClip> Load();
    }

    public interface IAsyncConditionalVideoClipLoader
    {
        UniTask<VideoClip> LoadAsync();
    }

    public interface IAsyncConditionalVideoClipsLoader
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalVideoClipLoader<in TParam1>
    {
        VideoClip Load(TParam1 param1);
    }

    public interface IConditionalVideoClipsLoader<in TParam1>
    {
        IEnumerable<VideoClip> Load(TParam1 param1);
    }

    public interface IAsyncConditionalVideoClipLoader<in TParam1>
    {
        UniTask<VideoClip> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalVideoClipsLoader<in TParam1>
    {
        UniTask<IEnumerable<VideoClip>> LoadAsync(TParam1 param1);
    }

    #endregion
}