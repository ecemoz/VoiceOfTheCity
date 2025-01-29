using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoiceOfTheCity.Models {

    public class User
    {
        [Key]
        public int Id {get; set;}

        [Required]
        [MaxLength(50)]
        public string Username {get; set;}
       
        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [MaxLength(255)]
        public string PasswordHash {get; set;}
        
        [Required]
        public string Role {get; set;} = "User";
        
        [MaxLength(100)]
        public string? Location {get; set;}
        public int ReportedIssuesCount {get; set;} = 0;
        public bool isVerified {get; set;} = false;
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public ICollection<Report> Reports {get; set;}
    }
}