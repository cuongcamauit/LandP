using LandPApi.Data;
using LandPApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace LandPApi.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);

                await _context.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _context.Set<T>().AsQueryable();
            if (includeProperties != null)
                includeProperties.ToList().ForEach(include =>
                {
                    if (include != null)
                        query = query.Include(include);
                });
            return await query.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<T?> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties)
        {
            //IQueryable<T> query = _context.Set<T>();
            //query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            //return await query.FirstOrDefaultAsync(n => n.Id == id);

            var query = _context.Set<T>().AsQueryable();
            if (includeProperties != null)
                includeProperties.ToList().ForEach(include =>
                {
                    if (include != null)
                        query = query.Include(include);
                });
            return await query.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.UpdateRange(entity);

            await _context.SaveChangesAsync();
        }
    }
}
