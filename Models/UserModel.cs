using ATC_BE.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ATC_BE.Models
{
    public class UserModel
    {
        
        //[Required]
        //public int UserId { get; set; } // this will be used for easier relationships between db tables

        [Required]
        public string? AccountId { get; set; } // thise represent the account id when its registered using identity

        [Key]
        [EmailAddress]
        [Required]
        [MaxLength(100)]
        public string? Email { get; set; }

        // User info data
        [Required]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Required]
        public string? Role { get; set; }

        [Required]
        public string? Gender { get; set; }

        // Optional fields
        public DateTime? BirthDate { get; set; }
        public Nationality? Nationality { get; set; }


        // account status
        // remote percentage
    }
}
