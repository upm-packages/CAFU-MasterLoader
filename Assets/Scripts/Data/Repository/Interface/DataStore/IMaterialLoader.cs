using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IMaterialLoader
    {
        Material Load();
    }

    public interface IMaterialLoader<in TKey>
    {
        Material Load(TKey key);
    }

    public interface IIndexedMaterialLoader
    {
        Material Load(int index);
    }

    public interface IConditionalMaterialLoader
    {
        Material Load(Func<Material, bool> predicate);
    }

    public interface IMaterialsLoader
    {
        IEnumerable<Material> Load();
    }

    public interface IMaterialsLoader<in TKey>
    {
        IEnumerable<Material> Load(TKey key);
    }

    public interface IIndexedMaterialsLoader
    {
        IEnumerable<Material> Load(int index);
    }

    public interface IConditionalMaterialsLoader
    {
        IEnumerable<Material> Load(Func<Material, bool> predicate);
    }

    public interface IAsyncMaterialLoader
    {
        UniTask<Material> LoadAsync();
    }

    public interface IAsyncMaterialLoader<in TKey>
    {
        UniTask<Material> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedMaterialLoader
    {
        UniTask<Material> LoadAsync(int index);
    }

    public interface IAsyncConditionalMaterialLoader
    {
        UniTask<Material> LoadAsync(Func<Material, bool> predicate);
    }

    public interface IAsyncMaterialsLoader
    {
        UniTask<IEnumerable<Material>> LoadAsync();
    }

    public interface IAsyncMaterialsLoader<in TKey>
    {
        UniTask<IEnumerable<Material>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedMaterialsLoader
    {
        UniTask<IEnumerable<Material>> LoadAsync(int index);
    }

    public interface IAsyncConditionalMaterialsLoader
    {
        UniTask<IEnumerable<Material>> LoadAsync(Func<Material, bool> predicate);
    }
}