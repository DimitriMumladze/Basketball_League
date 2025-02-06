namespace Basketball.League.Domain.Entities;

public class TeamOwner
{
    //FK
    public int TeamId { get; set; }
    //FK
    public int OwnerId { get; set; }

    public decimal OwnershipPercentage { get; set; }
}
