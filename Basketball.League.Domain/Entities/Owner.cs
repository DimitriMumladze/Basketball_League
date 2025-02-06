using System.Numerics;

namespace Basketball.League.Domain.Entities;

public class Owner
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public BigInteger NetWorth { get; set; }
}
