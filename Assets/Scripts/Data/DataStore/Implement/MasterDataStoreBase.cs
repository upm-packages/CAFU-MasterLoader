using System.Collections.Generic;
using System.Linq;
using CAFU.MasterLoader.Application.Delegate;
using CAFU.MasterLoader.Data.Repository.Interface.DataStore;

namespace CAFU.MasterLoader.Data.DataStore.Implement
{
    public abstract class MasterDataStoreBase<TValue> :
        IVariantLoader<TValue>,
        IVariantsLoader<TValue>,
        IElementCountable
    {
        protected MasterDataStoreBase(IEnumerable<TValue> masters)
        {
            Masters = masters;
        }

        protected IEnumerable<TValue> Masters { get; }

        TValue IVariantLoader<TValue>.Load()
        {
            return Masters.FirstOrDefault();
        }

        IEnumerable<TValue> IVariantsLoader<TValue>.Load()
        {
            return Masters;
        }

        int IElementCountable.Count()
        {
            return Masters.Count();
        }
    }

    public abstract class MasterDataStoreBase<TParam1, TValue> : MasterDataStoreBase<TValue>,
        IConditionalVariantLoader<TParam1, TValue>,
        IConditionalVariantsLoader<TParam1, TValue>
    {
        protected MasterDataStoreBase(IEnumerable<TValue> masters, MasterPredicate<TParam1, TValue> predicate) : base(masters)
        {
            Predicate = predicate;
        }

        private MasterPredicate<TParam1, TValue> Predicate { get; }

        TValue IConditionalVariantLoader<TParam1, TValue>.Load(TParam1 param1)
        {
            return Masters.FirstOrDefault(x => Predicate(param1, x));
        }

        IEnumerable<TValue> IConditionalVariantsLoader<TParam1, TValue>.Load(TParam1 param1)
        {
            return Masters.Where(x => Predicate(param1, x));
        }
    }
}