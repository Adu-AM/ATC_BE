using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ATC_BE.Models
{
    public class OfficeModel
    {
        [Key]
        [Required]
        public int OfficeId { get; set; }
        [Required]
        public string BuildingName { get; set; } = String.Empty;
        [Required]
        public int Floor { get; set; }
        [Required]
        public int TotalDeskCount { get; set; }
        [Required]
        public int UsableDeskCount { get; set; }
        public string OfficeAdmin { get; set; } = String.Empty;
        public double Width { get; set; }
        public double Length { get; set; }

        /// <summary>
        /// Building Relationship
        /// </summary>
        [JsonIgnore]
        public BuildingModel? Building { get; set; }
        public int BuildingId { get; set; }


        /// <summary>
        /// Desk Relationship
        /// </summary>
        [JsonIgnore]
        public ICollection<DeskModel>? DeskList { get; set; }
    }
}
