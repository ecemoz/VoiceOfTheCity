using AutoMapper;
using Microsoft.CodeAnalysis.Options;
using VoiceOfTheCity.DTOs;
using VoiceOfTheCity.Models;

namespace VoiceOfTheCity.Mappers {

    public class UserProfile : Profile {

        public UserProfile() {

            CreateMap<User,UserDto>();

            CreateMap<RegisterUserDto,User>();

            CreateMap<UserUpdateDto,User>()
            .ForAllProperty(opts => opts.Condition((src, dest, srcMember) => srcMember !=null));
        }
    }
}