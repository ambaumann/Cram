using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CramCore.DomainModels
{
    public class CatOwner : ICatOwner
    {
        public string Name { get; }
        private readonly ObservableCollection<ICat> _cats;
        public ReadOnlyObservableCollection<ICat> CatsReadonly { get; }
        public INotifyCollectionChanged CatsNotifyCollectionChanged => CatsReadonly;
    

        public CatOwner(string ownerName)
        {
            Name = ownerName;
            _cats = new ObservableCollection<ICat>();
            CatsReadonly = new ReadOnlyObservableCollection<ICat>(_cats);
        }

        public CatOwner(string ownerName, IEnumerable<ICat> cats)
        {
            Name = ownerName;
            _cats = new ObservableCollection<ICat>(cats);
            CatsReadonly = new ReadOnlyObservableCollection<ICat>(_cats);
        }

        public void AddCat(ICat aCat)
        {
            _cats.Add(aCat);
        }

        public bool Equals(IDomainValue otherDomainModelValue)
        {
            //because no two cat owners are the same even when they are themselves.
            return false;
        }

        public bool Equals(ICatOwner comparable)
        {
            return comparable != null && Name.Equals(comparable.Name);
        }

        public override bool Equals(object obj)
        {
            ICatOwner catOwner = obj as ICatOwner;
            return catOwner != null && Equals(catOwner);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_cats != null ? _cats.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (CatsReadonly != null ? CatsReadonly.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
