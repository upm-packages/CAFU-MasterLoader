using System.Collections.Generic;
using UniRx.Async;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IConstantValueLoader<out TValue> where TValue : struct
    {
        TValue Load();
    }

    public interface IConstantValuesLoader<out TValue> where TValue : struct
    {
        IEnumerable<TValue> Load();
    }

    public interface IAsyncConstantValueLoader<TValue> where TValue : struct
    {
        UniTask<TValue> LoadAsync();
    }

    public interface IAsyncConstantValuesLoader<TValue> where TValue : struct
    {
        UniTask<IEnumerable<TValue>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedConstantValueLoader<out TValue> where TValue : struct
    {
        TValue Load(int index);
    }

    public interface IIndexedConstantValuesLoader<out TValue> where TValue : struct
    {
        IEnumerable<TValue> Load(int index);
    }

    public interface IAsyncIndexedConstantValueLoader<TValue> where TValue : struct
    {
        UniTask<TValue> LoadAsync(int index);
    }

    public interface IAsyncIndexedConstantValuesLoader<TValue> where TValue : struct
    {
        UniTask<IEnumerable<TValue>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalConstantValueLoader<out TValue> where TValue : struct
    {
        TValue Load();
    }

    public interface IConditionalConstantValuesLoader<out TValue> where TValue : struct
    {
        IEnumerable<TValue> Load();
    }

    public interface IAsyncConditionalConstantValueLoader<TValue> where TValue : struct
    {
        UniTask<TValue> LoadAsync();
    }

    public interface IAsyncConditionalConstantValuesLoader<TValue> where TValue : struct
    {
        UniTask<IEnumerable<TValue>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalConstantValueLoader<in TParam1, out TValue> where TValue : struct
    {
        TValue Load(TParam1 param1);
    }

    public interface IConditionalConstantValuesLoader<in TParam1, out TValue> where TValue : struct
    {
        IEnumerable<TValue> Load(TParam1 param1);
    }

    public interface IAsyncConditionalConstantValueLoader<in TParam1, TValue> where TValue : struct
    {
        UniTask<TValue> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalConstantValuesLoader<in TParam1, TValue> where TValue : struct
    {
        UniTask<IEnumerable<TValue>> LoadAsync(TParam1 param1);
    }

    #endregion
}