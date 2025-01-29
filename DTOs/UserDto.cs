using VoiceOfTheCity.Enums;

namespace VoiceOfTheCity.DTOs {

    public class UserDto {

        public int Id {get; set;}
        public string Username {get; set;}
        public UserRole Role {get; set;}
        public string? ProfileImagePath {get; set;}
        public string? UserLocation {get; set;}
        public int ReportedIssuesCount {get; set;}
        public bool IsVerified {get; set;}
        public DateTime UserCreatedAt {get; set;}
    }
}