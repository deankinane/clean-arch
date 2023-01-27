using CleanArch.Application.Contracts.Persistence;
using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Persistence.Repositories
{
    public class ExoplanetRepository : BaseRepository<Exoplanet>, IExoplanetRepository
    {
        public ExoplanetRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IReadOnlyList<Exoplanet>> GetHabitablePlanets()
        {
           return await appDbContext.Exoplanets.Where(x => x.InHabitableZone).ToListAsync();
        }
    }
}
