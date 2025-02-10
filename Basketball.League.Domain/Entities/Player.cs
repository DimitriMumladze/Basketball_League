using Basketball.League.Domain.Entities;

public class Player
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public int JerseyNumber { get; set; }
    public int PositionId { get; set; } 
    public Position Position { get; set; } = null!; 
    public long Salary { get; set; }
    public DateTime DateBirth { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; } = null!;
}