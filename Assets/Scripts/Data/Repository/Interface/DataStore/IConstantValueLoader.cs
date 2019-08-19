using System.Collections.Generic;
using UniRx.Async;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IConstantValueLoader<out TValue> where TValue : struct
    {
        TValue Load();
    }

    public interface IConstantValueLoader<in TKey, out TValue> where TValue : struct
    {
        TValue Load(TKey key);
    }

    public interface IIndexedConstantValueLoader<out TValue> where TValue : struct
    {
        TValue Load(int index);
    }

    public interface IConstantValuesLoader<out TValue> where TValue : struct
    {
        IEnumerable<TValue> Load();
    }

    public interface IConstantValuesLoader<in TKey, out TValue> where TValue : struct
    {
        IEnumerable<TValue> Load(TKey key);
    }

    public interface IIndexedConstantValuesLoader<out TValue> where TValue : struct
    {
        IEnumerable<TValue> Load(int index);
    }

    public interface IAsyncConstantValueLoader<TValue> where TValue : struct
    {
        UniTask<TValue> LoadAsync();
    }

    public interface IAsyncConstantValueLoader<in TKey, TValue> where TValue : struct
    {
        UniTask<TValue> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedConstantValueLoader<TValue> where TValue : struct
    {
        UniTask<TValue> LoadAsync(int index);
    }

    public interface IAsyncConstantValuesLoader<TValue> where TValue : struct
    {
        UniTask<IEnumerable<TValue>> LoadAsync();
    }

    public interface IAsyncConstantValuesLoader<in TKey, TValue> where TValue : struct
    {
        UniTask<IEnumerable<TValue>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedConstantValuesLoader<TValue> where TValue : struct
    {
        UniTask<IEnumerable<TValue>> LoadAsync(int index);
    }
}