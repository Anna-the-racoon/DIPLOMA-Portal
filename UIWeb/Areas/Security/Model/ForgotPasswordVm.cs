using System.ComponentModel.DataAnnotations;

namespace UIWeb.Areas.Security.Model
{
    public class ForgotPasswordVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
