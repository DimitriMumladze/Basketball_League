using System.Numerics;

namespace Basketball.League.Domain.Entities;

public class Owner
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public long NetWorth { get; set; }

    public ICollection<TeamOwner> TeamOwners { get; set; } = new List<TeamOwner>();
}
