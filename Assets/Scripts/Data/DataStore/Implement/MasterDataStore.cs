using System;
using System.Collections.Generic;
using System.Linq;
using CAFU.MasterLoader.Application.Delegate;
using CAFU.MasterLoader.Data.Repository.Interface.DataStore;

namespace CAFU.MasterLoader.Data.DataStore.Implement
{
    public class MasterDataStore<TKey, TValue> :
        IVariantLoader<TKey, TValue>,
        IVariantsLoader<TValue>,
        IConditionalVariantsLoader<TValue>
    {
        public MasterDataStore(IEnumerable<TValue> masters, MasterKeySelector<TKey, TValue> keySelector)
        {
            Masters = masters;
            KeySelector = keySelector;
        }

        private IEnumerable<TValue> Masters { get; }

        private MasterKeySelector<TKey, TValue> KeySelector { get; }

        TValue IVariantLoader<TKey, TValue>.Load(TKey key)
        {
            return Masters.FirstOrDefault(x => KeySelector(x).Equals(key));
        }

        IEnumerable<TValue> IVariantsLoader<TValue>.Load()
        {
            return Masters;
        }

        IEnumerable<TValue> IConditionalVariantsLoader<TValue>.Load(Func<TValue, bool> predicate)
        {
            return Masters.Where(predicate);
        }
    }
}