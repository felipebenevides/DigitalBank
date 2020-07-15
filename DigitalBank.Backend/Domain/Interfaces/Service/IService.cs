using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IService<TEntity>
    {
        TEntity GetById(Guid id);
        void AddBulk(IEnumerable<TEntity> entities);
        void AddOrUpdate(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
