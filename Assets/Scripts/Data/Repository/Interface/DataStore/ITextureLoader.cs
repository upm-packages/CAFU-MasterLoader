using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface ITextureLoader
    {
        Texture Load();
    }

    public interface ITexturesLoader
    {
        IEnumerable<Texture> Load();
    }

    public interface IAsyncTextureLoader
    {
        UniTask<Texture> LoadAsync();
    }

    public interface IAsyncTexturesLoader
    {
        UniTask<IEnumerable<Texture>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedTextureLoader
    {
        Texture Load(int index);
    }

    public interface IIndexedTexturesLoader
    {
        IEnumerable<Texture> Load(int index);
    }

    public interface IAsyncIndexedTextureLoader
    {
        UniTask<Texture> LoadAsync(int index);
    }

    public interface IAsyncIndexedTexturesLoader
    {
        UniTask<IEnumerable<Texture>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalTextureLoader
    {
        Texture Load();
    }

    public interface IConditionalTexturesLoader
    {
        IEnumerable<Texture> Load();
    }

    public interface IAsyncConditionalTextureLoader
    {
        UniTask<Texture> LoadAsync();
    }

    public interface IAsyncConditionalTexturesLoader
    {
        UniTask<IEnumerable<Texture>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalTextureLoader<in TParam1>
    {
        Texture Load(TParam1 param1);
    }

    public interface IConditionalTexturesLoader<in TParam1>
    {
        IEnumerable<Texture> Load(TParam1 param1);
    }

    public interface IAsyncConditionalTextureLoader<in TParam1>
    {
        UniTask<Texture> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalTexturesLoader<in TParam1>
    {
        UniTask<IEnumerable<Texture>> LoadAsync(TParam1 param1);
    }

    #endregion
}