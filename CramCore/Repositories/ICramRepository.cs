using System.Collections.Generic;
using CramCore.DomainModels;

namespace CramCore.Repositories
{
    public interface ICramRepository
    {
        IEnumerable<ICatOwner> GetAllCatOwners();
    }
}