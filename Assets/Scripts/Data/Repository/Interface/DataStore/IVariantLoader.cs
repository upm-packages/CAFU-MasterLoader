using System.Collections.Generic;
using UniRx.Async;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IVariantLoader<out TValue>
    {
        TValue Load();
    }

    public interface IVariantLoader<in TKey, out TValue>
    {
        TValue Load(TKey key);
    }

    public interface IIndexedVariantLoader<out TValue>
    {
        TValue Load(int index);
    }

    public interface IVariantsLoader<out TValue>
    {
        IEnumerable<TValue> Load();
    }

    public interface IVariantsLoader<in TKey, out TValue>
    {
        IEnumerable<TValue> Load(TKey key);
    }

    public interface IIndexedVariantsLoader<out TValue>
    {
        IEnumerable<TValue> Load(int index);
    }

    public interface IAsyncVariantLoader<TValue>
    {
        UniTask<TValue> LoadAsync();
    }

    public interface IAsyncVariantLoader<in TKey, TValue>
    {
        UniTask<TValue> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedVariantLoader<TValue>
    {
        UniTask<TValue> LoadAsync(int index);
    }

    public interface IAsyncVariantsLoader<TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync();
    }

    public interface IAsyncVariantsLoader<in TKey, TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedVariantsLoader<TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync(int index);
    }
}