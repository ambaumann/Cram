using System.Collections.Generic;

namespace CramServer.EntityFramework
{
    public class CatOwner
    {
        public int CatOwnerId { get; set; }
        public string Name { get; set; }
        
        public virtual List<Cat> Cats { get; set; } 
    }
}