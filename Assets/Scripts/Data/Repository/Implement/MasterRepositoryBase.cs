using System.Collections.Generic;
using CAFU.MasterLoader.Data.Repository.Interface.DataStore;
using CAFU.MasterLoader.Domain.UseCase.Interface.Repository;

namespace CAFU.MasterLoader.Data.Repository.Implement
{
    public abstract class MasterRepositoryBase<TValue> :
        IMasterLoader<TValue>,
        IMastersLoader<TValue>
    {
        protected MasterRepositoryBase(IVariantLoader<TValue> variantLoader, IVariantsLoader<TValue> variantsLoader)
        {
            VariantLoader = variantLoader;
            VariantsLoader = variantsLoader;
        }

        private IVariantLoader<TValue> VariantLoader { get; }
        private IVariantsLoader<TValue> VariantsLoader { get; }

        TValue IMasterLoader<TValue>.Load()
        {
            return VariantLoader.Load();
        }

        IEnumerable<TValue> IMastersLoader<TValue>.LoadAll()
        {
            return VariantsLoader.Load();
        }
    }

    public abstract class MasterRepositoryBase<TKey, TValue> : MasterRepositoryBase<TValue>,
        IMasterLoader<TKey, TValue>,
        IMastersLoader<TKey, TValue>
    {
        protected MasterRepositoryBase(IVariantLoader<TValue> variantLoader, IVariantsLoader<TValue> variantsLoader, IConditionalVariantLoader<TKey, TValue> conditionalVariantLoader, IConditionalVariantsLoader<TKey, TValue> conditionalVariantsLoader) : base(variantLoader, variantsLoader)
        {
            ConditionalVariantLoader = conditionalVariantLoader;
            ConditionalVariantsLoader = conditionalVariantsLoader;
        }

        private IConditionalVariantLoader<TKey, TValue> ConditionalVariantLoader { get; }
        private IConditionalVariantsLoader<TKey, TValue> ConditionalVariantsLoader { get; }

        TValue IMasterLoader<TKey, TValue>.Load(TKey param1)
        {
            return ConditionalVariantLoader.Load(param1);
        }

        IEnumerable<TValue> IMastersLoader<TKey, TValue>.LoadAll(TKey key)
        {
            return ConditionalVariantsLoader.Load(key);
        }
    }
}