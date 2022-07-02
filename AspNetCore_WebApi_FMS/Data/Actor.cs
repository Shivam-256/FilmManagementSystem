using System;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Data
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
