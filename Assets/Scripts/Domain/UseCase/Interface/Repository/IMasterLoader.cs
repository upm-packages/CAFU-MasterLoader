using System;
using System.Collections.Generic;

namespace CAFU.MasterLoader.Domain.UseCase.Interface.Repository
{
    public interface IMasterLoader<in TKey, out TValue>
    {
        IEnumerable<TValue> LoadAll();
        IEnumerable<TValue> LoadAll(Func<TValue, bool> predicate);
        TValue Load(TKey key);
    }
}