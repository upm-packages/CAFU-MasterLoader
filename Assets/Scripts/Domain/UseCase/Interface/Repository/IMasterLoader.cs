using System.Collections.Generic;

// ReSharper disable UnusedMember.Global

namespace CAFU.MasterLoader.Domain.UseCase.Interface.Repository
{
    public interface IMasterLoader<out TValue>
    {
        TValue Load();
    }

    public interface IMastersLoader<out TValue>
    {
        IEnumerable<TValue> LoadAll();
    }

    public interface IMasterLoader<in TParam1, out TValue>
    {
        TValue Load(TParam1 param1);
    }

    public interface IMastersLoader<in TParam1, out TValue>
    {
        IEnumerable<TValue> LoadAll(TParam1 param1);
    }
}