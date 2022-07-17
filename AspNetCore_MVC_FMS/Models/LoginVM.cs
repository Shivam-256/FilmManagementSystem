using System.ComponentModel.DataAnnotations;
namespace AspNetCore_Mvc_FMS.Models
{
    public class LoginVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Username")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { set; get; }
        public bool RememberMe { get; set; }
    }
}