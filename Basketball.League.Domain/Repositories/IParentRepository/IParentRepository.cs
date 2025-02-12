using Basketball.League.Domain.Entities;

namespace Basketball.League.Domain.Repositories.IParentRepository;

public interface IParentRepository<T> where T : class
{
    Task<ICollection<T>> GetAllAsync();
    Task<T> GetById(int id);
    Task<int> Create(T entity);
    Task Delete(T entity);
    Task SaveChanges();
}
