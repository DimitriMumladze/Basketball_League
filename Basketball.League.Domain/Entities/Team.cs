namespace Basketball.League.Domain.Entities;

public class Team
{
    public int Id { get; set; }
    public DateTime CreationTime { get; set; }

    //FK
    public int CityId { get; set; }
}
