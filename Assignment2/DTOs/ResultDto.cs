using System.ComponentModel.DataAnnotations;
namespace Assignment2.DTOs
{
    public class ResultDto
    {
        public TimeSpan? FinishTime { get; set; }
        public int? Position { get; set; }
        [MaxLength(20)] public string AveragePace { get; set; } = "";
        [Required, MaxLength(20)] public string ResultStatus { get; set; } = "Finished";
    }
}
