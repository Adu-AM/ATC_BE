namespace ATC_BE.Models
{
    public class OfficeModel
    {
        public int OfficeId { get; set; }
        public string BuildingName { get; set; } = String.Empty;
        public int Floor { get; set; }
        public int TotalDeskCount { get; set; }
        public int UsableDeskCount { get; set; }
        public string OfficeAdmin { get; set; } = String.Empty;
        public double  Width { get; set; }
        public double Length { get; set; }
    }
}
