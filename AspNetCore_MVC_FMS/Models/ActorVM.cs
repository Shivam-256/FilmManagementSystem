using System.Collections.Generic;

namespace AspNetCore_MVC_FMS.Models
{
    public class ActorVM
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public virtual ICollection<FilmVM> Films { get; set; }
    }
}
