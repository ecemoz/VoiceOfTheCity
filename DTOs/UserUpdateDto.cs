namespace VoiceOfTheCity.DTOs{

    public class UserUpdateDto {

        public string? Username {get; set;}
        public string? Email {get; set;}
        public string? UserLocation {get; set;}
        public string? ProfileImagePath {get; set;}
        public bool? IsVerified {get; set;}
    }
}