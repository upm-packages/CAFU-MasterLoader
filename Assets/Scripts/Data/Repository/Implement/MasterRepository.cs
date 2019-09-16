using System;
using System.Collections.Generic;
using CAFU.MasterLoader.Data.Repository.Interface.DataStore;
using CAFU.MasterLoader.Domain.UseCase.Interface.Repository;

namespace CAFU.MasterLoader.Data.Repository.Implement
{
    public class MasterRepository<TKey, TValue> : IMasterLoader<TKey, TValue>
    {
        public MasterRepository(IVariantLoader<TKey, TValue> variantLoader, IVariantsLoader<TValue> variantsLoader, IConditionalVariantsLoader<TValue> conditionalVariantsLoader)
        {
            VariantLoader = variantLoader;
            VariantsLoader = variantsLoader;
            ConditionalVariantsLoader = conditionalVariantsLoader;
        }

        private IVariantLoader<TKey, TValue> VariantLoader { get; }
        private IVariantsLoader<TValue> VariantsLoader { get; }
        private IConditionalVariantsLoader<TValue> ConditionalVariantsLoader { get; }

        IEnumerable<TValue> IMasterLoader<TKey, TValue>.LoadAll()
        {
            return VariantsLoader.Load();
        }

        IEnumerable<TValue> IMasterLoader<TKey, TValue>.LoadAll(Func<TValue, bool> predicate)
        {
            return ConditionalVariantsLoader.Load(predicate);
        }

        TValue IMasterLoader<TKey, TValue>.Load(TKey key)
        {
            return VariantLoader.Load(key);
        }
    }
}