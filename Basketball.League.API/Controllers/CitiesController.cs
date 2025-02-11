using Basketball.League.Application.Features.Cities.Queries;
using Basketball.League.Application.Features.Dtos.CityMap;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Basketball.League.API.Controllers;

[Controller]
[Route("api/cities")]
public class CitiesController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ICollection<CityDto>>> GetAll([FromRoute] GetAllCitiesQuery query)
    {
        var cities = await mediator.Send(query);
        return Ok(cities);
    }
}
