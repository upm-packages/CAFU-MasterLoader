using System.Collections.Generic;
using UniRx.Async;

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    public interface IStringLoader
    {
        string Load();
    }

    public interface IStringLoader<in TKey>
    {
        string Load(TKey key);
    }

    public interface IIndexedStringLoader
    {
        string Load(int index);
    }

    public interface IStringsLoader
    {
        IEnumerable<string> Load();
    }

    public interface IStringsLoader<in TKey>
    {
        IEnumerable<string> Load(TKey key);
    }

    public interface IIndexedStringsLoader
    {
        IEnumerable<string> Load(int index);
    }

    public interface IAsyncStringLoader
    {
        UniTask<string> LoadAsync();
    }

    public interface IAsyncStringLoader<in TKey>
    {
        UniTask<string> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedStringLoader
    {
        UniTask<string> LoadAsync(int index);
    }

    public interface IAsyncStringsLoader
    {
        UniTask<IEnumerable<string>> LoadAsync();
    }

    public interface IAsyncStringsLoader<in TKey>
    {
        UniTask<IEnumerable<string>> LoadAsync(TKey key);
    }

    public interface IAsyncIndexedStringsLoader
    {
        UniTask<IEnumerable<string>> LoadAsync(int index);
    }
}