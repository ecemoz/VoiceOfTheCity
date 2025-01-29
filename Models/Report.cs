using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceOfTheCity.Models {
    
    public class Report
    {
        [Key]
        public int Id{get; set;}

        [Required]
        [MaxLength(255)]
        public string Title {get; set; }

        [Required]
        [MaxLength(100)]
        public string Category {get; set;}

        [Required]
        public double Latitude {get; set;}

        [Required]
        public double Longitude {get; set;}

        public string? Address {get; set;}

        [Required]
        [ForeignKey("User")]
        public int ReporterId {get; set;}

        public string Status {get; set;} ="Pending";

        public DateTime ReportCreatedAt {get; set;} = DateTime.Now;

        public DateTime ReportUpdatedAt {get ; set;} =  DateTime.Now;
    }
}