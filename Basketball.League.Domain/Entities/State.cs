namespace Basketball.League.Domain.Entities;

public class State
{
    public int Id { get; set; }
    public string StateName { get; set; } = null!;

    public ICollection<City> Cities { get; set; } = new List<City>();
}
