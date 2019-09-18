namespace CAFU.MasterLoader.Application.Delegate
{
    public delegate bool MasterPredicate<in TParam1, in TValue>(TParam1 param1, TValue param2);
}