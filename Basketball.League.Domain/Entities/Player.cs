using Basketball.League.Domain.Entities.Enums;
using System.Numerics;

namespace Basketball.League.Domain.Entities;

public class Player
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int JerseyNumber { get; set; }
    public Position Position { get; set; }
    public BigInteger salary { get; set; }
    public DateTime DateBirth { get; set; }
    // FK
    public int TeamId { get; set; }
}
