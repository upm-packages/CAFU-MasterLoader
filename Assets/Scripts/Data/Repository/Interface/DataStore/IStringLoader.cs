using System.Collections.Generic;
using Cysharp.Threading.Tasks;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IStringLoader
    {
        string Load();
    }

    public interface IStringsLoader
    {
        IEnumerable<string> Load();
    }

    public interface IAsyncStringLoader
    {
        UniTask<string> LoadAsync();
    }

    public interface IAsyncStringsLoader
    {
        UniTask<IEnumerable<string>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedStringLoader
    {
        string Load(int index);
    }

    public interface IIndexedStringsLoader
    {
        IEnumerable<string> Load(int index);
    }

    public interface IAsyncIndexedStringLoader
    {
        UniTask<string> LoadAsync(int index);
    }

    public interface IAsyncIndexedStringsLoader
    {
        UniTask<IEnumerable<string>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalStringLoader
    {
        string Load();
    }

    public interface IConditionalStringsLoader
    {
        IEnumerable<string> Load();
    }

    public interface IAsyncConditionalStringLoader
    {
        UniTask<string> LoadAsync();
    }

    public interface IAsyncConditionalStringsLoader
    {
        UniTask<IEnumerable<string>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalStringLoader<in TParam1>
    {
        string Load(TParam1 param1);
    }

    public interface IConditionalStringsLoader<in TParam1>
    {
        IEnumerable<string> Load(TParam1 param1);
    }

    public interface IAsyncConditionalStringLoader<in TParam1>
    {
        UniTask<string> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalStringsLoader<in TParam1>
    {
        UniTask<IEnumerable<string>> LoadAsync(TParam1 param1);
    }

    #endregion
}