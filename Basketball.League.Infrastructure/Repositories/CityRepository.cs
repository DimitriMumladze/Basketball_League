using Basketball.League.Domain.Entities;
using Basketball.League.Domain.Repositories;
using Basketball.League.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Basketball.League.Infrastructure.Repositories;

internal class CityRepository(LeagueDbContext dbContext) : ICityRepository
{
    public Task<int> Create(City entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(City entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<City>> GetAllAsync()
    {
        var cities = await dbContext.Cities.Include(x => x.Teams).ToListAsync();
        return cities;
    }

    public Task<City> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task SaveChanges()
    {
        throw new NotImplementedException();
    }
}
