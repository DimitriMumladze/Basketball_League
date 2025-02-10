using Basketball.League.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Basketball.League.Infrastructure.Persistence;

internal class LeagueDbContext(DbContextOptions<LeagueDbContext> options) : DbContext(options)
{
    internal DbSet<City> Cities { get; set; }
    internal DbSet<Owner> Owners { get; set; }
    internal DbSet<Player> Players { get; set; }
    internal DbSet<State> States { get; set; }
    internal DbSet<Team> Teams { get; set; }
    internal DbSet<TeamOwner> TeamOwners { get; set; }
}
