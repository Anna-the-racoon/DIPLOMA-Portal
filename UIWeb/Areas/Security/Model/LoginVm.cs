using System.ComponentModel.DataAnnotations;

namespace UIWeb.Areas.Security.Model
{
    public class LoginVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "remember me?")]
        public bool RememberMe { get; set; }
    }
}
