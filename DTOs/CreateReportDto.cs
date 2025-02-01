using System.ComponentModel.DataAnnotations;

namespace VoiceOfTheCity.DTOs {

    public class CreateReportDto {

        [Required]
        [MaxLength(255)]
        public string Title {get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description {get; set;}

        [Required]
        [MaxLength(100)]
        public string Category {get; set;}

        [Required]
        public double Latitude {get; set;}

        [Required]
        public double Longitude {get; set;}

        public string? Address {get; set;}

        [Required]
        public int ReporterId {get; set;}
    }
}