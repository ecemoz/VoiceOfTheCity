namespace VoiceOfTheCity.DTOs {

    public class RegisterUserDto {

        public string Username {get; set;}
        public string Email {get; set;}
        public string PasswordHash;
        public string UserRole {get; set;}
        public string? UserLocation{get; set;}
    }
}