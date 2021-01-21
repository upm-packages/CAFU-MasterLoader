using System.Collections.Generic;
using UniRx.Async;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Data.Repository.Interface.DataStore
{
    #region Basic

    public interface IVariantLoader<out TValue>
    {
        TValue Load();
    }

    public interface IVariantsLoader<out TValue>
    {
        IEnumerable<TValue> Load();
    }

    public interface IAsyncVariantLoader<TValue>
    {
        UniTask<TValue> LoadAsync();
    }

    public interface IAsyncVariantsLoader<TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync();
    }

    #endregion

    #region Indexed

    public interface IIndexedVariantLoader<out TValue>
    {
        TValue Load(int index);
    }

    public interface IIndexedVariantsLoader<out TValue>
    {
        IEnumerable<TValue> Load(int index);
    }

    public interface IAsyncIndexedVariantLoader<TValue>
    {
        UniTask<TValue> LoadAsync(int index);
    }

    public interface IAsyncIndexedVariantsLoader<TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync(int index);
    }

    #endregion

    #region Conditional

    public interface IConditionalVariantLoader<out TValue>
    {
        TValue Load();
    }

    public interface IConditionalVariantsLoader<out TValue>
    {
        IEnumerable<TValue> Load();
    }

    public interface IAsyncConditionalVariantLoader<TValue>
    {
        UniTask<TValue> LoadAsync();
    }

    public interface IAsyncConditionalVariantsLoader<TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync();
    }

    #endregion

    #region Conditional (1 param)

    public interface IConditionalVariantLoader<in TParam1, out TValue>
    {
        TValue Load(TParam1 param1);
    }

    public interface IConditionalVariantsLoader<in TParam1, out TValue>
    {
        IEnumerable<TValue> Load(TParam1 param1);
    }

    public interface IAsyncConditionalVariantLoader<in TParam1, TValue>
    {
        UniTask<TValue> LoadAsync(TParam1 param1);
    }

    public interface IAsyncConditionalVariantsLoader<in TParam1, TValue>
    {
        UniTask<IEnumerable<TValue>> LoadAsync(TParam1 param1);
    }

    #endregion

    public static class VariantLoaderExtensions
    {
        #region Basic

        public static TValue LoadOne<TValue>(this IVariantLoader<TValue> self)
        {
            return self.Load();
        }

        public static IEnumerable<TValue> LoadAll<TValue>(this IVariantsLoader<TValue> self)
        {
            return self.Load();
        }

        public static async UniTask<TValue> LoadOneAsync<TValue>(this IAsyncVariantLoader<TValue> self)
        {
            return await self.LoadAsync();
        }

        public static async UniTask<IEnumerable<TValue>> LoadAllAsync<TValue>(this IAsyncVariantsLoader<TValue> self)
        {
            return await self.LoadAsync();
        }

        #endregion

        #region Indexed

        public static TValue LoadOneWithIndex<TValue>(this IIndexedVariantLoader<TValue> self, int index)
        {
            return self.Load(index);
        }

        public static IEnumerable<TValue> LoadAllWithIndex<TValue>(this IIndexedVariantsLoader<TValue> self, int index)
        {
            return self.Load(index);
        }

        public static async UniTask<TValue> LoadOneWithIndexAsync<TValue>(this IAsyncIndexedVariantLoader<TValue> self, int index)
        {
            return await self.LoadAsync(index);
        }

        public static async UniTask<IEnumerable<TValue>> LoadAllWithIndexAsync<TValue>(this IAsyncIndexedVariantsLoader<TValue> self, int index)
        {
            return await self.LoadAsync(index);
        }

        #endregion

        #region Conditional

        public static TValue LoadOneWithCondition<TValue>(this IConditionalVariantLoader<TValue> self)
        {
            return self.Load();
        }

        public static IEnumerable<TValue> LoadAllWithCondition<TValue>(this IConditionalVariantsLoader<TValue> self)
        {
            return self.Load();
        }

        public static async UniTask<TValue> LoadOneWithConditionAsync<TValue>(this IAsyncConditionalVariantLoader<TValue> self)
        {
            return await self.LoadAsync();
        }

        public static async UniTask<IEnumerable<TValue>> LoadAllWithConditionAsync<TValue>(this IAsyncConditionalVariantsLoader<TValue> self)
        {
            return await self.LoadAsync();
        }

        #endregion

        #region Conditional (1 param)

        public static TValue LoadOneWithCondition<TParam1, TValue>(this IConditionalVariantLoader<TParam1, TValue> self, TParam1 param1)
        {
            return self.Load(param1);
        }

        public static IEnumerable<TValue> LoadAllWithCondition<TParam1, TValue>(this IConditionalVariantsLoader<TParam1, TValue> self, TParam1 param1)
        {
            return self.Load(param1);
        }

        public static async UniTask<TValue> LoadOneWithConditionAsync<TParam1, TValue>(this IAsyncConditionalVariantLoader<TParam1, TValue> self, TParam1 param1)
        {
            return await self.LoadAsync(param1);
        }

        public static async UniTask<IEnumerable<TValue>> LoadAllWithConditionAsync<TParam1, TValue>(this IAsyncConditionalVariantsLoader<TParam1, TValue> self, TParam1 param1)
        {
            return await self.LoadAsync(param1);
        }

        #endregion
    }
}