namespace Basketball.League.Domain.Entities;

public class TeamOwner
{
    public int TeamId { get; set; }
    public int OwnerId { get; set; }
    public decimal OwnershipPercentage { get; set; }

    public Team Team { get; set; } = null!;
    public Owner Owner { get; set; } = null!;
}
