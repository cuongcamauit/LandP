using Azure;
using LandPApi.Dto;
using System.Linq.Expressions;

namespace LandPApi.Base
{
    public interface IBaseRepository<T> where T : class, IEntityBase
    {
        Task<Dto.Response> GetAllAsync();
        Task<Dto.Response> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<Dto.Response> GetByIdAsync(Guid id);
        Task<Dto.Response> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties);
        Task<Dto.Response> AddAsync(T entity);
        Task<Dto.Response> UpdateAsync(T entity);
        Task<Dto.Response> DeleteAsync(Guid id);
    }
}
