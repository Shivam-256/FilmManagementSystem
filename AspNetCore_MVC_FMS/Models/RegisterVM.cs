using AspNetCore_MVC_FMS.Models;
using System.ComponentModel.DataAnnotations;
namespace AspNetCore_Mvc_FMS.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Enter Username")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { set; get; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int RoleId { set; get; }
        public virtual RoleVM Role { set; get; }
    }
}