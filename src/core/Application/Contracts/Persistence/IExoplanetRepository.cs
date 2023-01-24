using CleanArch.Domain.Entities;

namespace CleanArch.Application.Contracts.Persistence
{
    public interface IExoplanetRepository : IAsyncRepository<Exoplanet>
    {
        Task<IReadOnlyList<Exoplanet>> GetHabitablePlanets(); 
    }
}
