namespace Basketball.League.Domain.Entities;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime CreationTime { get; set; }
    public int CityId { get; set; }

    public City City { get; set; } = null!;
    public ICollection<Player> Players { get; set; } = new List<Player>();
    public ICollection<TeamOwner> TeamOwners { get; set; } = new List<TeamOwner>();
}
