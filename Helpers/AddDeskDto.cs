using ATC_BE.Data.Enums;

namespace ATC_BE.Helpers
{
    public class AddDeskDto
    {
        public int DeskId { get; set; }
        public DeskStatus Vacancy { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public string UserEmail { get; set; }   
    }
}
