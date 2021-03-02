using System.Linq;
using API.DTO;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser,MemberDTO>()
                .ForMember(
                    dest => dest.PhotoUrl, 
                    options => options.MapFrom(
                        source => source.Photos.FirstOrDefault(x => x.IsMain).Url
                    ))
                .ForMember(
                    dest => dest.Age,
                    options => options.MapFrom(
                        source => source.DateOfBirth.CalculateAge()
                    ));
            CreateMap<Photo,PhotoDTO>();
        }
    }
}