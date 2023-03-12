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

        public async Task<Dto.Response> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return new Response 
            { 
                Success = true,
                Message = "Created a " + entity.GetType().Name,
                Data = entity
            };
        }


        public async Task<Dto.Response> DeleteAsync(Guid id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);

                await _context.SaveChangesAsync();
            }
            return new Response 
            { 
                Success = false,
                Message = "Delete a " + entity!.GetType().Name
            };

        }

        public async Task<Response> GetAllAsync()
        {
            return new Response
            {
                Success = true,
                Message = "Get all ",
                Data = await _context.Set<T>().ToListAsync()
            };
        }

        public async Task<Response> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _context.Set<T>().AsQueryable();
            if (includeProperties != null)
                includeProperties.ToList().ForEach(include =>
                {
                    if (include != null)
                        query = query.Include(include);
                });
            return new Response
            {
                Success = true,
                Message = "Get all",
                Data = await query.ToListAsync()
            };
        }

        public async Task<Response> GetByIdAsync(Guid id)
        {
            return new Response
            {
                Success = true,
                Message = "Get all ",
                Data = await _context.Set<T>().FirstOrDefaultAsync(o => o.Id == id)
            };
        }

        public async Task<Response> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties)
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
            return new Response
            {
                Success = true,
                Message = "Get all ",
                Data = await query.FirstOrDefaultAsync(n => n.Id == id)
            };
        }

        public async Task<Response> UpdateAsync(T entity)
        {
            _context.UpdateRange(entity);

            await _context.SaveChangesAsync();
            return new Response{
                Success = true,
                Message = "Updated successfully"
            };
        }
    }
}
