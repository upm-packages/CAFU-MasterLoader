using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IAnimationClipLoader
    {
        AnimationClip Load();
    }

    public interface IAnimationClipsLoader
    {
        IEnumerable<AnimationClip> Load();
    }

    public interface IAsyncAnimationClipLoader
    {
        UniTask<AnimationClip> LoadAsync();
    }

    public interface IAsyncAnimationClipsLoader
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedAnimationClipLoader
    {
        AnimationClip Load(int index);
    }

    public interface IIndexedAnimationClipsLoader
    {
        IEnumerable<AnimationClip> Load(int index);
    }

    public interface IAsyncIndexedAnimationClipLoader
    {
        UniTask<AnimationClip> LoadAsync(int index);
    }

    public interface IAsyncIndexedAnimationClipsLoader
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalAnimationClipLoader
    {
        AnimationClip Load();
    }

    public interface IConditionalAnimationClipsLoader
    {
        IEnumerable<AnimationClip> Load();
    }

    public interface IAsyncConditionalAnimationClipLoader
    {
        UniTask<AnimationClip> LoadAsync();
    }

    public interface IAsyncConditionalAnimationClipsLoader
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalAnimationClipLoader<in TParam1>
    {
        AnimationClip Load(TParam1 param1);
    }

    public interface IConditionalAnimationClipsLoader<in TParam1>
    {
        IEnumerable<AnimationClip> Load(TParam1 param1);
    }

    public interface IAsyncConditionalAnimationClipLoader<in TParam1>
    {
        UniTask<AnimationClip> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalAnimationClipsLoader<in TParam1>
    {
        UniTask<IEnumerable<AnimationClip>> LoadAsync(TParam1 param1);
    }

    #endregion
}