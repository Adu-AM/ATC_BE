using System.ComponentModel.DataAnnotations;

namespace ATC_BE.Models
{
    public class LoginModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; } // as username

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
