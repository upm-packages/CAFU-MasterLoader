using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IAudioClipLoader
    {
        AudioClip Load();
    }

    public interface IAudioClipLoader<in TKey>
    {
        AudioClip Load(TKey key);
    }

    public interface IIndexedAudioClipLoader
    {
        AudioClip Load(int index);
    }

    public interface IConditionalAudioClipLoader
    {
        AudioClip Load(Func<AudioClip, bool> predicate);
    }

    public interface IAudioClipsLoader
    {
        IEnumerable<AudioClip> Load();
    }

    public interface IAudioClipsLoader<in TKey>
    {
        IEnumerable<AudioClip> Load(TKey key);
    }

    public interface IIndexedAudioClipsLoader
    {
        IEnumerable<AudioClip> Load(int index);
    }

    public interface IConditionalAudioClipsLoader
    {
        IEnumerable<AudioClip> Load(Func<AudioClip, bool> predicate);
    }

    public interface IAsyncAudioClipLoader
    {
        UniTask<AudioClip> LoadAsync();
    }

    public interface IAsyncAudioClipLoader<in TKey>
    {
        UniTask<AudioClip> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedAudioClipLoader
    {
        UniTask<AudioClip> LoadAsync(int index);
    }

    public interface IAsyncConditionalAudioClipLoader
    {
        UniTask<AudioClip> LoadAsync(Func<AudioClip, bool> predicate);
    }

    public interface IAsyncAudioClipsLoader
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync();
    }

    public interface IAsyncAudioClipsLoader<in TKey>
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedAudioClipsLoader
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync(int index);
    }

    public interface IAsyncConditionalAudioClipsLoader
    {
        UniTask<IEnumerable<AudioClip>> LoadAsync(Func<AudioClip, bool> predicate);
    }
}