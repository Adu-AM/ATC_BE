using ATC_BE.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ATC_BE.Models
{
    public class RequestRemoteModel
    {
        [Key]
        [Required]
        public int RequestId { get; set; }

        [Required]
        [Range(0, 100)]
        public int RemotePercentage { get; set; } // 0-100%

        [Required]
        public string Reason { get; set; }// Free text // The reason for request

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Column(TypeName = "nvarchar(24)")]
        public RequestStatus Status { get; set; } = RequestStatus.Pending;


        [ForeignKey("Email")]
        public string UserEmail { get; set; } 
        [JsonIgnore]
        public virtual UserModel? User { get; set; }
    }
}
