using CramCore.DataContracts;
using CramCore.DataConversion;
using CramCore.DomainModels;
using Moq;
using NUnit.Framework;

namespace CramCoreTest.DataConversion
{
    [TestFixture]
    public class AutoMapperDTOMapperTests
    {
        [Test]
        public void TestCatMapping()
        {
            ICat cat = Cat.WithName("Shadow").WithCutenessLevel(9006).GiveBirth();
            AutoMapperDTOMapper mapper = new AutoMapperDTOMapper();
            CatDataContract dto = mapper.Map<ICat, CatDataContract>(cat);
            Assert.AreEqual(cat.Name, dto.Name);
            Assert.AreEqual(cat.CutenessLevel, dto.CutenessLevel);
            ICat cat2 = mapper.Map<CatDataContract, ICat>(dto);
            Assert.AreEqual(cat, cat2);
        }

        [Test]
        public void TestCatOwnerMapping()
        {
            ICatOwner aCatOwner = new CatOwner("Bill");
            Mock<ICat> mockCat = new Mock<ICat>();
            aCatOwner.AddCat(mockCat.Object);
            AutoMapperDTOMapper mapper = new AutoMapperDTOMapper();
            CatOwnerDataContract dto = mapper.Map<ICatOwner, CatOwnerDataContract>(aCatOwner);
            Assert.AreEqual(aCatOwner.Name, dto.Name);
            Assert.AreEqual(mockCat.Object, dto.Cats[0]);
            ICatOwner aCatOwner2 = mapper.Map<CatOwnerDataContract, ICatOwner>(dto);
            Assert.AreEqual(aCatOwner, aCatOwner2);
        }
    }
}
