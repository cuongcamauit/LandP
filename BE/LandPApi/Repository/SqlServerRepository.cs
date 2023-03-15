using LandPApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LandPApi.Repository
{
    public class SqlServerRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public SqlServerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
            => _context.Set<T>().Add(entity);

        public void Delete(T entity)
            => _context.Set<T>().Remove(entity);

        public IQueryable<T> ReadAll()
            => _context.Set<T>().AsNoTracking();

        public IQueryable<T> ReadByCondition(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(condition).AsNoTracking();
        }

        public void Save()
            => _context.SaveChanges();

        public void Update(T entity)
            => _context.Set<T>().Update(entity);

    }
}
