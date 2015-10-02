using System.Runtime.Serialization;

namespace CramCore.DataContracts
{
    [DataContract]
    public class CatDataContract
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int CutenessLevel { get; set; }
    }
}
