using System.Data.Entity;

namespace CramServer.EntityFramework
{
    public class CramContext : DbContext
    {
        public DbSet<Cat>  Cats { get; set; }
        public DbSet<CatOwner> CatOwners { get; set; } 
    }
}