using ATC_BE.Data.Enums;
using ATC_BE.Data.DefaultData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATC_BE.Models
{
    public class UserModel
    {

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

        [Required]
        public string? AccountStatus { get; set; }  // La creearea contului acesta devine activ

        [Required]
        [Range(0, 100)]
        public int RemotePercentage { get; set; } = 0;

        // Optional fields
        public DateTime? BirthDate { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        public Nationality? Nationality { get; set; }
    }
}
