using ATC_BE.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ATC_BE.Helpers
{
    public class DeskDto
    {
        public int DeskId { get; set; }
        public DeskStatus Vacancy { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        [EmailAddress]
        public string? UserEmail { get; set; } = null;
        public int OfficeId { get; set; }
    }
}
