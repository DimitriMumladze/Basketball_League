using System.Numerics;

namespace Basketball.League.Domain.Entities;

public class City
{
    public int Id { get; set; }
    public string CityName { get; set; }
    public BigInteger Population {  get; set; }
    //FK
    public int StateId { get; set; }
}
