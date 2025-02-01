using AutoMapper;
using VoiceOfTheCity.DTOs;
using VoiceOfTheCity.Models;

namespace VoiceOfTheCity.Mappers {
    
    public class ReportProfile: Profile {

        public ReportProfile() {

            CreateMap<Report, ReportDto>() 
            .ForMember(dest => dest.ReporterUsername, opt => opt.MapFrom(src => src.Reporter.Username));

            CreateMap<CreateReportDto, Report>();

            CreateMap<UpdateReportDto, Report>()
            .ForAllMembers(opts => opts.Condition((src, dest,srcMember) => srcMember != null));
        }
    }
}