using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IAnimationClipLoader
    {
        AnimationClip Load();
    }

    public interface IAnimationClipLoader<in TKey>
    {
        AnimationClip Load(TKey key);
    }

    public interface IIndexedAnimationClipLoader
    {
        AnimationClip Load(int index);
    }

    public interface IConditionalAnimationClipLoader
    {
        AnimationClip Load(Func<AnimationClip, bool> predicate);
    }

    public interface IAnimationClipsLoader
    {
        IEnumerable<AnimationClip> Load();
    }

    public interface IAnimationClipsLoader<in TKey>
    {
        IEnumerable<AnimationClip> Load(TKey key);
    }

    public interface IIndexedAnimationClipsLoader
    {
        IEnumerable<AnimationClip> Load(int index);
    }

    public interface IConditionalAnimationClipsLoader
    {
        IEnumerable<AnimationClip> Load(Func<AnimationClip, bool> predicate);
    }

    public interface IAsyncAnimationClipLoader
    {
        UniTask<AnimationClip> LoadAsync();
    }

    public interface IAsyncAnimationClipLoader<in TKey>
    {
        UniTask<AnimationClip> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedAnimationClipLoader
    {
        UniTask<AnimationClip> LoadAsync(int index);
    }

    public interface IAsyncConditionalAnimationClipLoader
    {
        UniTask<AnimationClip> LoadAsync(Func<AnimationClip, bool> predicate);
    }

    public interface IAsyncAnimationClipsLoader
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync();
    }

    public interface IAsyncAnimationClipsLoader<in TKey>
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedAnimationClipsLoader
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync(int index);
    }

    public interface IAsyncConditionalAnimationClipsLoader
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync(Func<AnimationClip, bool> predicate);
    }
}