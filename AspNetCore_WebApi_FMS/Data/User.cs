using System;
using System.Collections.Generic;

namespace AspNetCore_WebApi_FMS.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
