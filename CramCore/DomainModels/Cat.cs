
namespace CramCore.DomainModels
{
    public class Cat : ICat
    {
        public string Name { get; private set; }
        public int CutenessLevel { get; private set; }

        public class CatBuilder
        {
            private readonly Cat _aCat;

            public CatBuilder(string name)
            {
                _aCat = new Cat {Name = name};
            }

            public CatBuilder2 WithCutenessLevel(int cutenessLevel)
            {
                _aCat.CutenessLevel = cutenessLevel;
                return  new CatBuilder2(_aCat);
            }

            public class CatBuilder2
            {
                private readonly Cat _aCat;

                public CatBuilder2(Cat catYetToBeBorn)
                {
                    _aCat = catYetToBeBorn;
                }

                public Cat GiveBirth()
                {
                    //TODO possible validation code here
                    //with validator as a dependecy
                    return _aCat;
                }
            }
        }

        public static CatBuilder WithName(string name)
        {
            return new CatBuilder(name);
        }

        private Cat()
        {
            
        }

        public bool Equals(ICat comparable)
        {
            return comparable != null && Name == comparable.Name;
        }

        public override bool Equals(object obj)
        {
            ICat cat = obj as ICat;
            return cat != null && Equals(cat);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0)*397) ^ CutenessLevel;
            }
        }
    }
}