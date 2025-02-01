using VoiceOfTheCity.Enums;

namespace VoiceOfTheCity.DTOs {

    public class ReportDto {

        public int Id {get; set;}

        public string Title {get; set;}

        public string Description {get; set;}

        public string Category {get; set;}

        public double Latitude {get; set;}

        public double Longitude {get; set;}

        public string Address {get; set;}

        public string ReporterUsername {get; set;}

        public ReportStatus Status {get; set;}

        public DateTime ReportCreatedAt {get; set;}

        public DateTime ReportUpdatedAt {get; set;}
    }
}
