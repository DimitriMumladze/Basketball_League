using Basketball.League.Domain.Entities;

namespace Basketball.League.Application.Features.Dtos.TeamMap;

public class TeamDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime CreationTime { get; set; }
    public City City { get; set; } = null!;
}
