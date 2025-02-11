using Basketball.League.Application.Features.Dtos;
using MediatR;

namespace Basketball.League.Application.Features.Cities.Queries;

public class GetAllCitiesQuery : IRequest<ICollection<CityDto>>
{
}
