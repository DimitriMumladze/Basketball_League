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
    internal DbSet<Position> Positions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {                                 
        base.OnModelCreating(modelBuilder);

        // City and State relationship (one-to-many: City belongs to State)
        modelBuilder.Entity<City>()
          .HasOne(c => c.State)
          .WithMany(s => s.Cities)
          .HasForeignKey(c => c.StateId);

        // Team and City relationship (one-to-many: Team belongs to City)
        modelBuilder.Entity<Team>()
          .HasOne(t => t.City)
          .WithMany(c => c.Teams)
          .HasForeignKey(t => t.CityId);

        // Player and Team relationship (one-to-many: Player belongs to Team)
        modelBuilder.Entity<Player>()
          .HasOne(p => p.Team)
          .WithMany(t => t.Players)
          .HasForeignKey(p => p.TeamId);

        modelBuilder.Entity<Player>()
           .HasOne(p => p.Position)
           .WithMany(pos => pos.Players) // Add this line!
           .HasForeignKey(p => p.PositionId);

        // TeamOwner (join table) configuration for many-to-many relationship between Team and Owner
        modelBuilder.Entity<TeamOwner>()
          .HasKey(to => new { to.TeamId, to.OwnerId }); // Composite primary key

        modelBuilder.Entity<TeamOwner>()
          .HasOne(to => to.Team)
          .WithMany(t => t.TeamOwners)
          .HasForeignKey(to => to.TeamId);

        modelBuilder.Entity<TeamOwner>()
          .HasOne(to => to.Owner)
          .WithMany(o => o.TeamOwners)
          .HasForeignKey(to => to.OwnerId);


    }
}