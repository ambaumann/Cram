using CramCore.DomainModels;
using NUnit.Framework;

namespace CramCoreTest.DomainModels
{
    [TestFixture]
    public class CatTests
    {
        [Test]
        public void TestCatCreation()
        {
            Cat amazingCat = Cat.WithName("Meowzer").WithCutenessLevel(9008).GiveBirth();
            Assert.AreEqual("Meowzer", amazingCat.Name);
            Assert.AreEqual(9008, amazingCat.CutenessLevel);
        }

        [Test]
        public void TestTwoCatsWithTheSameNameAreEqual()
        {
            Cat cat1 = Cat.WithName("Meowzer").WithCutenessLevel(9008).GiveBirth();
            Cat cat2 = Cat.WithName("Meowzer").WithCutenessLevel(9003).GiveBirth();
            Assert.AreEqual(cat1, cat2);
        }
}
}