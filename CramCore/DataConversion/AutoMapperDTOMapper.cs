using System.Linq;
using AutoMapper;
using CramCore.DataContracts;
using CramCore.DomainModels;

namespace CramCore.DataConversion
{
    public class AutoMapperDTOMapper : IDTOMapper
    {
        public AutoMapperDTOMapper()
        {
            Mapper.CreateMap<ICat, CatDataContract>();
            Mapper.CreateMap<ICatOwner, CatOwnerDataContract>().ConvertUsing(x => new CatOwnerDataContract
            {
                Name = x.Name,
                Cats = x.CatsReadonly.ToList()
            });
            Mapper.CreateMap<CatDataContract, ICat>().ConvertUsing(x => new Cat.CatBuilder(x.Name).WithCutenessLevel(x.CutenessLevel).GiveBirth());
            Mapper.CreateMap<CatOwnerDataContract, ICatOwner>().ConvertUsing(x => {
                var owner = new CatOwner(x.Name);
                foreach (var cat in x.Cats)
                {
                    owner.AddCat(cat);
                }
                return owner;
            });
        }

        public U Map<T, U>(T source)
        {
            return Mapper.Map<T, U>(source);
        }
    }
}