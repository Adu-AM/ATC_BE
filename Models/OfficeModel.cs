using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ATC_BE.Models
{
    public class OfficeModel
    {
        [Key]
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

        //[JsonIgnore]
        //public BuildingModel Building { get; set; }
        //[JsonIgnore]
        //public int Building_Id { get; set; }
    }
}
