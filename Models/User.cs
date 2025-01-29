using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BCrypt.Net;
using VoiceOfTheCity.Enums;

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
        public UserRole Role {get; set;} = UserRole.User;

        [MaxLength(255)]
        public string? ProfileImagePath {get; set;}
        
        [MaxLength(100)]
        public string? Location {get; set;}
        public int ReportedIssuesCount {get; set;} = 0;
        public bool isVerified {get; set;} = false;
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public ICollection<Report> Reports {get; set;}

        public void SetPassword(string password) {
            PasswordHash =BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password) {
            return BCrypt.Net.BCrypt.Verify(password,PasswordHash);
        }
    }
}