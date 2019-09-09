using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface ISpriteLoader
    {
        Sprite Load();
    }

    public interface ISpriteLoader<in TKey>
    {
        Sprite Load(TKey key);
    }

    public interface IIndexedSpriteLoader
    {
        Sprite Load(int index);
    }

    public interface IConditionalSpriteLoader
    {
        Sprite Load(Func<Sprite, bool> predicate);
    }

    public interface ISpritesLoader
    {
        IEnumerable<Sprite> Load();
    }

    public interface ISpritesLoader<in TKey>
    {
        IEnumerable<Sprite> Load(TKey key);
    }

    public interface IIndexedSpritesLoader
    {
        IEnumerable<Sprite> Load(int index);
    }

    public interface IConditionalSpritesLoader
    {
        IEnumerable<Sprite> Load(Func<Sprite, bool> predicate);
    }

    public interface IAsyncSpriteLoader
    {
        UniTask<Sprite> LoadAsync();
    }

    public interface IAsyncSpriteLoader<in TKey>
    {
        UniTask<Sprite> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedSpriteLoader
    {
        UniTask<Sprite> LoadAsync(int index);
    }

    public interface IAsyncConditionalSpriteLoader
    {
        UniTask<Sprite> LoadAsync(Func<Sprite, bool> predicate);
    }

    public interface IAsyncSpritesLoader
    {
        UniTask<IEnumerable<Sprite>> LoadAsync();
    }

    public interface IAsyncSpritesLoader<in TKey>
    {
        UniTask<IEnumerable<Sprite>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedSpritesLoader
    {
        UniTask<IEnumerable<Sprite>> LoadAsync(int index);
    }

    public interface IAsyncConditionalSpritesLoader
    {
        UniTask<IEnumerable<Sprite>> LoadAsync(Func<Sprite, bool> predicate);
    }
}