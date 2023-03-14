using LandPApi.Data;
using LandPApi.Dto;
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

        public async Task<ICollection<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<ICollection<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _context.Set<T>().AsQueryable();
            if (includeProperties != null)
                includeProperties.ToList().ForEach(include =>
                {
                    if (include != null)
                        query = query.Include(include);
                });
            var result = await query.ToListAsync();
            return result;
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(o => o.Id == id);
            return result;
        }

        public async Task<T?> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _context.Set<T>().AsQueryable();
            if (includeProperties != null)
                includeProperties.ToList().ForEach(include =>
                {
                    if (include != null)
                        query = query.Include(include);
                });
            var result = await query.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task UpdateAsync(T entity)
        {
            _context.UpdateRange(entity);

            await _context.SaveChangesAsync();
        }
    }
}
