using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CramCore.DomainModels
{
    public interface ICatOwner : IComparableDomainValue<ICatOwner>
    {
        string Name { get; }
        ReadOnlyObservableCollection<ICat> CatsReadonly { get; }
        INotifyCollectionChanged CatsNotifyCollectionChanged { get; }
        void AddCat(ICat aCat);
    }
}