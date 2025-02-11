using Basketball.League.Application.Features.Dtos.CityMap;
using MediatR;

namespace Basketball.League.Application.Features.Cities.Queries;

public class GetAllCitiesQuery : IRequest<ICollection<CityDto>>
{
}
