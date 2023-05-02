using AutoMapper;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LandPApi.Service
{
    public class GenericService<V, D, E> : IGenericService<V, D, E> where V : class where D : class where E : class, BaseModel
    {
        public readonly IRepository<E> _repository;
        public IMapper _mapper;

        public GenericService(IRepository<E> repository, IMapper mapper) 
        { 
            _repository = repository;
            _mapper = mapper;
        }
        public D Create(V view)
        {
            var entity = _mapper.Map<E>(view);
            _repository.Create(entity);
            _repository.Save();
            return _mapper.Map<D>(entity);
        }

        public async Task Delete(Guid id)
        {
            var entity = await _repository.ReadByCondition(o => o.Id == id).FirstOrDefaultAsync();
            if (entity != null)
            {
                _repository.Delete(entity);
                _repository.Save();
            }
        }

        public async Task<List<D>> GetAll()
        {
            var result = await _repository.ReadAll().ToListAsync();
            return _mapper.Map<List<D>>(result); 
        }

        public async Task<List<D>> GetAll(params Expression<Func<E, object>>[] includeProperties)
        {
            var result = _repository.ReadAll();
            foreach (var item in includeProperties)
            {
                result = result.Include(item);
            }
            return _mapper.Map<List<D>>(await result.ToListAsync());
        }

        public async Task<D> GetById(Guid id)
        {
            var result = await _repository.ReadByCondition(o => o.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<D>(result);
        }

        public void Update(D dto)
        {
            var entity = _mapper.Map<E>(dto);
            _repository.Update(entity);
            _repository.Save();
        }
    }
}
