namespace VoiceOfTheCity.Models {

    public class User
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public string Email {get; set;}
        public string PasswordHash {get; set;}
        public string Role {get; set;} = "User";
        public string Location {get; set;}
        public int ReportedIssuesCount {get; set;} = 0;
        public bool isVerified {get; set;} = false;
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public ICollection<Report> Reports {get; set;}
    }
}