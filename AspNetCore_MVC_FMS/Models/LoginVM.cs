using System.ComponentModel.DataAnnotations;
namespace AspNetCore_Mvc_FMS.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Enter Username")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public char Password { set; get; }
        public bool RememberMe { get; set; }
    }
}