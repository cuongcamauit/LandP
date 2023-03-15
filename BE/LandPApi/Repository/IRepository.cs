using System.Linq.Expressions;

namespace LandPApi.Repository
{
    public interface IRepository<T>
    {
        void Create(T entity);
        IQueryable<T> ReadAll();
        IQueryable<T> ReadByCondition(Expression<Func<T, bool>> condition);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
