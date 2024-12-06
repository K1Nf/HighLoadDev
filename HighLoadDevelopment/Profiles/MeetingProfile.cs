using AutoMapper;
using HighLoadDevelopment.Contracts;
using HighLoadDevelopment.Contracts.DTO;
using HighLoadDevelopment.Models;
using Microsoft.Extensions.Logging;

namespace HighLoadDevelopment.Profiles
{
    public class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<Meeting, MeetingDTO>()
                .ForMember(dest => dest.UserDTO, opt => opt.MapFrom(src => src.User))
                .ForMember(dest => dest.TagsDTO, opt => opt.MapFrom(src => src.Tags));
                //.ReverseMap();
        }
    }

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.MeetingsDTO, opt => opt.MapFrom(src => src.Meetings))
                .ForMember(dest => dest.TagsDTO, opt => opt.MapFrom(src => src.Tags));


            CreateMap<User, UserShortDTO>()
                .ForMember(dest => dest.TagsDTO, opt => opt.MapFrom(src => src.Tags));
        }
    }

    public class VisitProfile : Profile
    {
        public VisitProfile()
        {
            CreateMap<Visit, VisitDTO>();
        }
    }

    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagDTO>();
        }
    }
}
