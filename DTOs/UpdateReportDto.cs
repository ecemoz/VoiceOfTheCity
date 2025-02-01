using System.ComponentModel.DataAnnotations;
using VoiceOfTheCity.Enums;

namespace VoiceOfTheCity.DTOs {

    public class UpdateReportDto {

    [MaxLength(255)]
    public string? Title {get; set;}

    [MaxLength(2000)]
    public string? Description {get; set;}

    [MaxLength(100)]
    public string? Category {get; set;}

    public double? Latitude {get; set;}

    public double? Longitude {get; set;}

    public string? Address {get; set;}

    public ReportStatus? Status {get; set;}
    
    }
}