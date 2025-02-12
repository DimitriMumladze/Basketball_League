using AutoMapper;
using Basketball.League.Application.Features.Dtos.CityMap;
using Basketball.League.Application.Features.Dtos.TeamMap;
using Basketball.League.Domain.Repositories;
using MediatR;

namespace Basketball.League.Application.Features.Cities.Queries;

public class GetAllTeamsQueryHandler(IMapper mapper, ITeamRepository teamRepository)
    : IRequestHandler<GetAllTeamsQuery, ICollection<TeamDto>>
{
    public async Task<ICollection<TeamDto>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
    {
        var teams = await teamRepository.GetAllAsync();
        var teamDtos = mapper.Map<ICollection<TeamDto>>(teams);

        return teamDtos!;
    }
}
