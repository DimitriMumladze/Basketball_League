using Basketball.League.Domain.Repositories;
using Basketball.League.Infrastructure.Persistence;
using Basketball.League.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basketball.League.Infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("LeagueDb");
        services.AddDbContext<LeagueDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<ICityRepository, CityRepository>();
    }
}
