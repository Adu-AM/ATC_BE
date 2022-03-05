using ATC_BE.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ATC_BE.Models
{
    public class UserRegisterModel
    {
        // User login data
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        // User info data
        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string? Role { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string? Gender { get; set; }

        // Optional fields
        public DateTime? BirthDate { get; set; }
        public Nationality? Nationality { get; set; }
    }
}
