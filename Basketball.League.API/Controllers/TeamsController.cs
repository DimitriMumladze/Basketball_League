using Basketball.League.Application.Features.Cities.Queries;
using Basketball.League.Application.Features.Dtos.TeamMap;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Basketball.League.API.Controllers;

[Controller]
[Route("api/teams")]
public class TeamsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ICollection<TeamDto>>> GetAll()
    {
        var query = new GetAllTeamsQuery();
        var teams = await mediator.Send(query);
        return Ok(teams);
    }
}
