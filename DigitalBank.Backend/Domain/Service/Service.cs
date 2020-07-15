using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public void AddBulk(IEnumerable<TEntity> entities)
        {
            _repository.AddBulk(entities);
        }

        public void AddOrUpdate(TEntity entity)
        {
            _repository.AddOrUpdate(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }
    }
}
