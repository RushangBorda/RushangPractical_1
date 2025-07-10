using Applications.Dtos;
using AutoMapper;
using Infrastructure.Model;

namespace RushangPractical.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Registration, RegistrationDto>().ReverseMap();
            CreateMap<RegistrationDto, Registration>().ReverseMap();
        }
    }
}
