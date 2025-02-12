using AutoMapper;
using Basketball.League.Domain.Entities;

namespace Basketball.League.Application.Features.Dtos.CityMap;

public class CitiesProfile : Profile
{
    public CitiesProfile()
    {
        CreateMap<City, CityDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.CityName))
            .ForMember(dest => dest.Population, opt => opt.MapFrom(src => src.Population))
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State.StateName)); // Map StateName directly
        CreateMap<CityDto, City>(); 
    }
}