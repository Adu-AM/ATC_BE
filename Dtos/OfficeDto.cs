namespace ATC_BE.Helpers
{
    public class OfficeDto
    {
        public string BuildingName { get; set; } = String.Empty;   

        public int Floor { get; set; } = 0;
        public int TotalDeskCount { get; set; } = 0;
        public int UsableDeskCount { get; set; } = 0;
        public string OfficeAdmin { get; set; } = String.Empty;
        public double Width { get; set; } = 0;
        public double Length { get; set; } = 0;
    }
}
