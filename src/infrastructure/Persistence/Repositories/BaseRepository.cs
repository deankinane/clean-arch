using CleanArch.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Persistence.Repositories;

public class BaseRepository<T> : IAsyncRepository<T>
   where T : class
{
    protected readonly AppDbContext appDbContext;

    public BaseRepository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
       await appDbContext.AddAsync<T>(entity);
       await appDbContext.SaveChangesAsync();

       return entity;
    }

    public async Task DeleteAsync(T entity)
    {
       appDbContext.Remove<T>(entity);
       await appDbContext.SaveChangesAsync();
    }

    public virtual async Task<T?> GetByIdAsync(Guid id)
    {
       return await appDbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
       return await appDbContext.Set<T>().ToListAsync();
    }

    public async Task UpdateAsync(T entity)
    {
       appDbContext.Update<T>(entity);
       await appDbContext.SaveChangesAsync();
    }
} 
