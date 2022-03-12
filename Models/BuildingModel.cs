using System.ComponentModel.DataAnnotations;
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
        public List<OfficeModel> OfficeList { get; set; }
    }
}
