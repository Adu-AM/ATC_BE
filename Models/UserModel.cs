using ATC_BE.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ATC_BE.Models
{
    public class UserModel
    {
        [Required]
        public string? AccountId { get; set; } // this represents the account id when its registered using identity

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

        [Required]
        public AccountStatus AccountStatus { get; set; } = AccountStatus.Active; // La creearea contului acesta devine activ

        [Required]
        [Range(0, 100)]
        public int RemotePercentage { get; set; } = 0;

        // Optional fields
        public DateTime? BirthDate { get; set; }
        public Nationality? Nationality { get; set; }
    }
}
