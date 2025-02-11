using AutoMapper;
using Basketball.League.Application.Features.Dtos.CityMap;
using Basketball.League.Domain.Repositories;
using MediatR;

namespace Basketball.League.Application.Features.Cities.Queries;

public class GetAllCitiesQueryHandler(IMapper mapper, ICityRepository cityRepository) 
    : IRequestHandler<GetAllCitiesQuery, ICollection<CityDto>>
{
    public async Task<ICollection<CityDto>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
    {
        var cities = await cityRepository.GetAllAsync();
        var citiesDtos = mapper.Map<ICollection<CityDto>>(cities);

        return citiesDtos!;
    }
}
