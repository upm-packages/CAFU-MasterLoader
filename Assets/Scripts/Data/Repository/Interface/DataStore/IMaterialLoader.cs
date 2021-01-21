using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IMaterialLoader
    {
        Material Load();
    }

    public interface IMaterialsLoader
    {
        IEnumerable<Material> Load();
    }

    public interface IAsyncMaterialLoader
    {
        UniTask<Material> LoadAsync();
    }

    public interface IAsyncMaterialsLoader
    {
        UniTask<IEnumerable<Material>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedMaterialLoader
    {
        Material Load(int index);
    }

    public interface IIndexedMaterialsLoader
    {
        IEnumerable<Material> Load(int index);
    }

    public interface IAsyncIndexedMaterialLoader
    {
        UniTask<Material> LoadAsync(int index);
    }

    public interface IAsyncIndexedMaterialsLoader
    {
        UniTask<IEnumerable<Material>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalMaterialLoader
    {
        Material Load();
    }

    public interface IConditionalMaterialsLoader
    {
        IEnumerable<Material> Load();
    }

    public interface IAsyncConditionalMaterialLoader
    {
        UniTask<Material> LoadAsync();
    }

    public interface IAsyncConditionalMaterialsLoader
    {
        UniTask<IEnumerable<Material>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalMaterialLoader<in TParam1>
    {
        Material Load(TParam1 param1);
    }

    public interface IConditionalMaterialsLoader<in TParam1>
    {
        IEnumerable<Material> Load(TParam1 param1);
    }

    public interface IAsyncConditionalMaterialLoader<in TParam1>
    {
        UniTask<Material> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalMaterialsLoader<in TParam1>
    {
        UniTask<IEnumerable<Material>> LoadAsync(TParam1 param1);
    }

    #endregion
}