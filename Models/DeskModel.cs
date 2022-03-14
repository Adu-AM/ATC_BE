using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ATC_BE.Data.Enums;

namespace ATC_BE.Models
{
    public class DeskModel
    {
        [Key]
        [Required]
        public int DeskId { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Column(TypeName = "nvarchar(24)")]
        public DeskStatus Vacancy { get; set; } = DeskStatus.Occupied;
        public double Width { get; set; }
        public double Length { get; set; }

        /// <summary>
        ///  User relationship
        /// </summary>
        [JsonIgnore]
        public UserModel? User { get; set; } = null;
        [EmailAddress]
        public string? UserEmail { get; set; } = null;

        /// <summary>
        /// Office Relationship
        /// </summary>
        [JsonIgnore]
        public OfficeModel? Office { get; set; }
        [Required]
        public int OfficeId { get; set; }
    }
}
