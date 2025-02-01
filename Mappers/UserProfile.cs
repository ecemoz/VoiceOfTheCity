using AutoMapper;
using VoiceOfTheCity.DTOs;
using VoiceOfTheCity.Models;

namespace VoiceOfTheCity.Mappers {

    public class UserProfile : Profile {

        public UserProfile() {

            CreateMap<User,UserDto>();

            CreateMap<RegisterUserDto,User>();

            CreateMap<UserUpdateDto,User>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember !=null));

            CreateMap<UploadImageDto, User>()
            .ForMember(dest=> dest.ProfileImagePath, opt => opt.Ignore());
        }
    }
}