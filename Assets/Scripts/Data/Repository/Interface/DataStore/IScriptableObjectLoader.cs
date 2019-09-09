using System;
using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IScriptableObjectLoader<out TValue> where TValue : ScriptableObject
    {
        TValue Load();
    }

    public interface IScriptableObjectLoader<in TKey, out TValue> where TValue : ScriptableObject
    {
        TValue Load(TKey key);
    }

    public interface IIndexedScriptableObjectLoader<out TValue> where TValue : ScriptableObject
    {
        TValue Load(int index);
    }

    public interface IConditionalScriptableObjectLoader<out TValue>
    {
        TValue Load(Func<TValue, bool> predicate);
    }

    public interface IScriptableObjectsLoader<out TValue> where TValue : ScriptableObject
    {
        IEnumerable<TValue> Load();
    }

    public interface IScriptableObjectsLoader<in TKey, out TValue> where TValue : ScriptableObject
    {
        IEnumerable<TValue> Load(TKey key);
    }

    public interface IIndexedScriptableObjectsLoader<out TValue> where TValue : ScriptableObject
    {
        IEnumerable<TValue> Load(int index);
    }

    public interface IConditionalScriptableObjectsLoader<out TValue>
    {
        IEnumerable<TValue> Load(Func<TValue, bool> predicate);
    }

    public interface IAsyncScriptableObjectLoader<TValue> where TValue : ScriptableObject
    {
        UniTask<TValue> LoadAsync();
    }

    public interface IAsyncScriptableObjectLoader<in TKey, TValue> where TValue : ScriptableObject
    {
        UniTask<TValue> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedScriptableObjectLoader<TValue> where TValue : ScriptableObject
    {
        UniTask<TValue> LoadAsync(int index);
    }

    public interface IAsyncConditionalScriptableObjectLoader<TValue>
    {
        UniTask<TValue> LoadAsync(Func<TValue, bool> predicate);
    }

    public interface IAsyncScriptableObjectsLoader<TValue> where TValue : ScriptableObject
    {
        UniTask<IEnumerable<TValue>> LoadAsync();
    }

    public interface IAsyncScriptableObjectsLoader<in TKey, TValue> where TValue : ScriptableObject
    {
        UniTask<IEnumerable<TValue>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedScriptableObjectsLoader<TValue> where TValue : ScriptableObject
    {
        UniTask<IEnumerable<TValue>> LoadAsync(int index);
    }

    public interface IAsyncConditionalScriptableObjectsLoader<TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync(Func<TValue, bool> predicate);
    }
}