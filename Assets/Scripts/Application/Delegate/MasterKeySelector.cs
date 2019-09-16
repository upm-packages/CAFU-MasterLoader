namespace CAFU.MasterLoader.Application.Delegate
{
    public delegate TKey MasterKeySelector<out TKey, in TValue>(TValue value);
}