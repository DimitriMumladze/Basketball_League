using Basketball.League.Domain.Entities;

namespace Basketball.League.Domain.Repositories;

public interface ICityRepository
{
    Task<ICollection<City>> GetAllAsync();
    Task<City> GetById(int id);
    Task<int> Create(City entity);
    Task Delete(City entity);
    Task SaveChanges();
}
