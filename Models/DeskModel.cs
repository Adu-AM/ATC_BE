using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ATC_BE.Data.Enums;

namespace ATC_BE.Models
{
    public class DeskModel
    {
        [Key]
        public int DeskId { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Column(TypeName = "nvarchar(24)")]
        public Status Vacancy { get; set; } = Status.Occupied;
        public double Width { get; set; }
        public double Length { get; set; }


        public UserModel User { get; set; } 
        [ForeignKey("UserId")]
        public string User_Id { get; set; } 
    }
}
