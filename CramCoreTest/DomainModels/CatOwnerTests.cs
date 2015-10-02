using System.Collections.Specialized;
using CramCore.DomainModels;
using Moq;
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

        [Test]
        public void TestCatsCollectionSignalsWhenCatIsAdded()
        {
            CatOwner anOwner = new CatOwner("Drake");
            Mock<ICat> mockCat = new Mock<ICat>();
            bool fired = false;
            NotifyCollectionChangedEventHandler handler = (a, b) => { fired = true; };
            anOwner.CatsNotifyCollectionChanged.CollectionChanged += handler;
            anOwner.AddCat(mockCat.Object);
            Assert.IsTrue(fired);
        }
    }
}