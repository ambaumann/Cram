namespace CramCore.DomainModels
{
    public interface ICat : IComparableDomainValue<ICat>
    {
        string Name { get; }
        int CutenessLevel { get; }
    }
}