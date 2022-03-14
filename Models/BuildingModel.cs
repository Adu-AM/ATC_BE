using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ATC_BE.Models
{
    public class BuildingModel
    {
        [Key]
        public int BuildingId { get; set; }
        [Required] 
        public string Name { get; set; } = string.Empty;
        [Required]
        public int FloorCount { get; set; }
        [Required]
        public string BuildingAddress { get; set; } = string.Empty;
        [JsonIgnore]
        public ICollection<OfficeModel>? OfficeList { get; set; }
    }
}
