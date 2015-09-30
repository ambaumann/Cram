namespace CramCore.DomainModels
{
    public interface IComparableDomainValue<in T> : IDomainValue where T:IComparableDomainValue<T>
    {
        bool Equals(T comparable);
    }
}