using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface ITextureLoader
    {
        Texture Load();
    }

    public interface ITextureLoader<in TKey>
    {
        Texture Load(TKey key);
    }

    public interface IIndexedTextureLoader
    {
        Texture Load(int index);
    }

    public interface IConditionalTextureLoader
    {
        Texture Load(Func<Texture, bool> predicate);
    }

    public interface ITexturesLoader
    {
        IEnumerable<Texture> Load();
    }

    public interface ITexturesLoader<in TKey>
    {
        IEnumerable<Texture> Load(TKey key);
    }

    public interface IIndexedTexturesLoader
    {
        IEnumerable<Texture> Load(int index);
    }

    public interface IConditionalTexturesLoader
    {
        IEnumerable<Texture> Load(Func<Texture, bool> predicate);
    }

    public interface IAsyncTextureLoader
    {
        UniTask<Texture> LoadAsync();
    }

    public interface IAsyncTextureLoader<in TKey>
    {
        UniTask<Texture> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedTextureLoader
    {
        UniTask<Texture> LoadAsync(int index);
    }

    public interface IAsyncConditionalTextureLoader
    {
        UniTask<Texture> LoadAsync(Func<Texture, bool> predicate);
    }

    public interface IAsyncTexturesLoader
    {
        UniTask<IEnumerable<Texture>> LoadAsync();
    }

    public interface IAsyncTexturesLoader<in TKey>
    {
        UniTask<IEnumerable<Texture>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedTexturesLoader
    {
        UniTask<IEnumerable<Texture>> LoadAsync(int index);
    }

    public interface IAsyncConditionalTexturesLoader
    {
        UniTask<IEnumerable<Texture>> LoadAsync(Func<Texture, bool> predicate);
    }
}