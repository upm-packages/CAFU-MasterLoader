using System;
using System.Collections.Generic;
using System.Linq;
using CAFU.MasterLoader.Data.Repository.Interface.DataStore;
using JetBrains.Annotations;

namespace CAFU.MasterLoader.Data.DataStore.Implement
{
    [PublicAPI]
    public abstract class MasterListLoaderBase<T> : IElementCountable
    {
        protected MasterListLoaderBase(IEnumerable<T> assets)
        {
            Assets = assets;
        }

        private IEnumerable<T> Assets { get; }

        public T Find(int index)
        {
            return Assets.ElementAt(index);
        }

        public T Find<TKey>(TKey key, Func<T, TKey> keySelector)
        {
            return Assets.First(x => keySelector(x).Equals(key));
        }

        public IEnumerable<T> FindAll<TKey>(TKey key, Func<T, TKey> keySelector)
        {
            return Assets.Where(x => keySelector(x).Equals(key));
        }

        int IElementCountable.Count()
        {
            return Assets.Count();
        }
    }
}