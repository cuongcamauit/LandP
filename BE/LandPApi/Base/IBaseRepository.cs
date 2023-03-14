using Azure;
using LandPApi.Dto;
using System.Linq.Expressions;

namespace LandPApi.Base
{
    public interface IBaseRepository<T> where T : class, IEntityBase
    {
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T?> GetByIdAsync(Guid id);
        Task<T?> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
