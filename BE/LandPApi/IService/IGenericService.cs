using LandPApi.Dto;
using LandPApi.View;
using System.Linq.Expressions;

namespace LandPApi.IService
{
    /// <summary>
    /// A Generic Serice
    /// V, D, E stand for:
    ///     View
    ///     Dto
    ///     Entity
    /// </summary>
    /// <remarks>
    ///     To do
    /// </remarks>
    public interface IGenericService<V, D, E>
    {
        D Create(V view);
        Task Delete(Guid id);
        Task<D> GetById(Guid Id);
        Task<List<D>> GetAll();
        Task<List<D>> GetAll(params Expression<Func<E, object>>[] includeProperties);
        void Update(D dto);
    }
}
