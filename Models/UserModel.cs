using ATC_BE.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        // User details
        [Required]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? LastName { get; set; }


        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Column(TypeName = "nvarchar(24)")]
        public UserRole Role { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Column(TypeName = "nvarchar(24)")]
        public Gender Gender { get; set; } = Gender.Other;

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Column(TypeName = "nvarchar(24)")]
        public AccountStatus AccountStatus { get; set; }  // La creearea contului acesta devine activ

        [Required]
        [Range(0, 100)]
        public int RemotePercentage { get; set; } = 0; // 0-100%

        // Optional fields
        public DateTime? BirthDate { get; set; } 

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Column(TypeName = "nvarchar(24)")]
        public Nationality? Nationality { get; set; }
    }
}
