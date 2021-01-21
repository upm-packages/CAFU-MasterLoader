using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IScriptableObjectLoader
    {
        ScriptableObject Load();
    }

    public interface IScriptableObjectsLoader
    {
        IEnumerable<ScriptableObject> Load();
    }

    public interface IAsyncScriptableObjectLoader
    {
        UniTask<ScriptableObject> LoadAsync();
    }

    public interface IAsyncScriptableObjectsLoader
    {
        UniTask<IEnumerable<ScriptableObject>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedScriptableObjectLoader
    {
        ScriptableObject Load(int index);
    }

    public interface IIndexedScriptableObjectsLoader
    {
        IEnumerable<ScriptableObject> Load(int index);
    }

    public interface IAsyncIndexedScriptableObjectLoader
    {
        UniTask<ScriptableObject> LoadAsync(int index);
    }

    public interface IAsyncIndexedScriptableObjectsLoader
    {
        UniTask<IEnumerable<ScriptableObject>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalScriptableObjectLoader
    {
        ScriptableObject Load();
    }

    public interface IConditionalScriptableObjectsLoader
    {
        IEnumerable<ScriptableObject> Load();
    }

    public interface IAsyncConditionalScriptableObjectLoader
    {
        UniTask<ScriptableObject> LoadAsync();
    }

    public interface IAsyncConditionalScriptableObjectsLoader
    {
        UniTask<IEnumerable<ScriptableObject>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalScriptableObjectLoader<in TParam1>
    {
        ScriptableObject Load(TParam1 param1);
    }

    public interface IConditionalScriptableObjectsLoader<in TParam1>
    {
        IEnumerable<ScriptableObject> Load(TParam1 param1);
    }

    public interface IAsyncConditionalScriptableObjectLoader<in TParam1>
    {
        UniTask<ScriptableObject> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalScriptableObjectsLoader<in TParam1>
    {
        UniTask<IEnumerable<ScriptableObject>> LoadAsync(TParam1 param1);
    }

    #endregion
}