using CramCore.DomainModels;
using NUnit.Framework;

namespace CramCoreTest.DomainModels
{
    [TestFixture]
    public class CatOwnerTests
    {
        [Test]
        public void TestCatOwnerCreationWithoutCats()
        {
            CatOwner anOwnerWithoutCats  = new CatOwner("Bill");
            Assert.AreEqual("Bill",anOwnerWithoutCats.Name);
            Assert.AreEqual(0, anOwnerWithoutCats.CatsReadonly.Count);
        }

        [Test]
        public void TestTwoOwnersWithTheSameNameAreEqual()
        {
            CatOwner anOwnerNamedBill = new CatOwner("Bill");
            CatOwner anotherOwnerNamedBill = new CatOwner("Bill");
            Assert.AreEqual(anOwnerNamedBill, anotherOwnerNamedBill);
        }
    }
}