using Basketball.League.Domain.Entities;
using Basketball.League.Domain.Repositories.IParentRepository;

namespace Basketball.League.Domain.Repositories;

public interface ITeamRepository : IParentRepository<Team>
{
}
