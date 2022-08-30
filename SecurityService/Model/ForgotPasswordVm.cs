using System.ComponentModel.DataAnnotations;

namespace SecurityService.Model
{
    public class ForgotPasswordVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
