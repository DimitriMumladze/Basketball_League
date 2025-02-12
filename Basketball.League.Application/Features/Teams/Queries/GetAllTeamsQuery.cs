using Basketball.League.Application.Features.Dtos.CityMap;
using Basketball.League.Application.Features.Dtos.TeamMap;
using MediatR;

namespace Basketball.League.Application.Features.Cities.Queries;

public class GetAllTeamsQuery : IRequest<ICollection<TeamDto>>
{
}
