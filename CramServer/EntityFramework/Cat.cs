namespace CramServer.EntityFramework
{
    public class Cat
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public int CutenessLevel { get; set; }

        public int CatOwnerId { get; set; }
        public virtual CatOwner CatOwner { get; set; }
    }
}