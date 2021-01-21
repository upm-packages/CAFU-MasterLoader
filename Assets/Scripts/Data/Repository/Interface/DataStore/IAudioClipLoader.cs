using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IAudioClipLoader
    {
        AudioClip Load();
    }

    public interface IAudioClipsLoader
    {
        IEnumerable<AudioClip> Load();
    }

    public interface IAsyncAudioClipLoader
    {
        UniTask<AudioClip> LoadAsync();
    }

    public interface IAsyncAudioClipsLoader
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedAudioClipLoader
    {
        AudioClip Load(int index);
    }

    public interface IIndexedAudioClipsLoader
    {
        IEnumerable<AudioClip> Load(int index);
    }

    public interface IAsyncIndexedAudioClipLoader
    {
        UniTask<AudioClip> LoadAsync(int index);
    }

    public interface IAsyncIndexedAudioClipsLoader
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalAudioClipLoader
    {
        AudioClip Load();
    }

    public interface IConditionalAudioClipsLoader
    {
        IEnumerable<AudioClip> Load();
    }

    public interface IAsyncConditionalAudioClipLoader
    {
        UniTask<AudioClip> LoadAsync();
    }

    public interface IAsyncConditionalAudioClipsLoader
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalAudioClipLoader<in TParam1>
    {
        AudioClip Load(TParam1 param1);
    }

    public interface IConditionalAudioClipsLoader<in TParam1>
    {
        IEnumerable<AudioClip> Load(TParam1 param1);
    }

    public interface IAsyncConditionalAudioClipLoader<in TParam1>
    {
        UniTask<AudioClip> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalAudioClipsLoader<in TParam1>
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync(TParam1 param1);
    }

    #endregion
}