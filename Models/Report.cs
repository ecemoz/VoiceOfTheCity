using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VoiceOfTheCity.Enums;

namespace VoiceOfTheCity.Models {
    
    public class Report
    {
        [Key]
        public int Id{get; set;}

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

        [ForeignKey("ReporterId")]
        public User Reporter {get; set;}

        [Required]
        public ReportStatus Status {get; set;} = ReportStatus.Pending;

        public DateTime ReportCreatedAt {get; set;} = DateTime.Now;

        public DateTime ReportUpdatedAt {get ; set;} =  DateTime.Now;
    }
}