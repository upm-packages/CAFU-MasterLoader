using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface ISpriteLoader
    {
        Sprite Load();
    }

    public interface ISpritesLoader
    {
        IEnumerable<Sprite> Load();
    }

    public interface IAsyncSpriteLoader
    {
        UniTask<Sprite> LoadAsync();
    }

    public interface IAsyncSpritesLoader
    {
        UniTask<IEnumerable<Sprite>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedSpriteLoader
    {
        Sprite Load(int index);
    }

    public interface IIndexedSpritesLoader
    {
        IEnumerable<Sprite> Load(int index);
    }

    public interface IAsyncIndexedSpriteLoader
    {
        UniTask<Sprite> LoadAsync(int index);
    }

    public interface IAsyncIndexedSpritesLoader
    {
        UniTask<IEnumerable<Sprite>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalSpriteLoader
    {
        Sprite Load();
    }

    public interface IConditionalSpritesLoader
    {
        IEnumerable<Sprite> Load();
    }

    public interface IAsyncConditionalSpriteLoader
    {
        UniTask<Sprite> LoadAsync();
    }

    public interface IAsyncConditionalSpritesLoader
    {
        UniTask<IEnumerable<Sprite>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalSpriteLoader<in TParam1>
    {
        Sprite Load(TParam1 param1);
    }

    public interface IConditionalSpritesLoader<in TParam1>
    {
        IEnumerable<Sprite> Load(TParam1 param1);
    }

    public interface IAsyncConditionalSpriteLoader<in TParam1>
    {
        UniTask<Sprite> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalSpritesLoader<in TParam1>
    {
        UniTask<IEnumerable<Sprite>> LoadAsync(TParam1 param1);
    }

    #endregion
}