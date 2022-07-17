﻿namespace AspNetCore_MVC_FMS.Models
{
    public class UserVM
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public virtual RoleVM Role { get; set; }
    }
}
