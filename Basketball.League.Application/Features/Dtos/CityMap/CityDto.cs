using Basketball.League.Domain.Entities;

namespace Basketball.League.Application.Features.Dtos.CityMap;

public class CityDto
{
    public int Id { get; set; }
    public string CityName { get; set; } = null!;
    public long Population { get; set; }
    public int StateId { get; set; }

    public State State { get; set; } = null!;
    public ICollection<Team> Teams { get; set; } = new List<Team>();
}
