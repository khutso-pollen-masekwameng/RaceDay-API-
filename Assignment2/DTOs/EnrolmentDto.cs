using System.ComponentModel.DataAnnotations;
namespace Assignment2.DTOs
{
    public class EnrolmentDto
    {
        [MaxLength(20)] public string? RaceNumber { get; set; }
        [Required, MaxLength(20)] public string Status { get; set; } = "Registered";
    }
}