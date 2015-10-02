using System.Collections.Generic;
using System.Runtime.Serialization;
using CramCore.DomainModels;

namespace CramCore.DataContracts
{
    [DataContract]
    public class CatOwnerDataContract
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<ICat> Cats { get; set; }
        /*

        string Name { get; }
        ReadOnlyObservableCollection<ICat> CatsReadonly { get; }
        INotifyCollectionChanged CatsNotifyCollectionChanged { get; }
        void AddCat(ICat aCat);
        */
    }
}