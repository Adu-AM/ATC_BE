namespace ATC_BE.Models
{
    public class BuildingModel
    {
        public int BuildingId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FloorCount { get; set; }
        public string BuildingAddress { get; set; } = string.Empty;
    }
}
