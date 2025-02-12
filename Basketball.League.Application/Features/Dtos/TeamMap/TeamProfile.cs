using AutoMapper;
using Basketball.League.Domain.Entities;

namespace Basketball.League.Application.Features.Dtos.TeamMap;

public class TeamsProfile : Profile
{
    public TeamsProfile()
    {
        CreateMap<Team, TeamDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.CreationTime, opt => opt.MapFrom(src => src.CreationTime))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City)); // Mapping City entity directly

        CreateMap<TeamDto, Team>();
    }
}
