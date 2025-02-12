using Basketball.League.Domain.Entities;
using Basketball.League.Domain.Repositories;
using Basketball.League.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Basketball.League.Infrastructure.Repositories;

internal class TeamRepository(LeagueDbContext dbContext) : ITeamRepository
{
    public Task<int> Create(Team entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Team entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<Team>> GetAllAsync()
    {
        var teams = await dbContext.Teams.ToListAsync();
        return teams;
    }

    public Task<Team> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task SaveChanges()
    {
        throw new NotImplementedException();
    }
}
