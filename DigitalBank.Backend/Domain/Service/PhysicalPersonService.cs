using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class PhysicalPersonService :  IPhysicalPersonService
    {
        private readonly IPhysicalPersonRepository _physicalPersonRepository;
        public PhysicalPersonService(IPhysicalPersonRepository physicalPersonRepository)
        {
            _physicalPersonRepository = physicalPersonRepository;
        }

        public void AddBulk(IEnumerable<PhysicalPerson> entities)
        {
            _physicalPersonRepository.AddBulk(entities);
        }

        public void AddOrUpdate(PhysicalPerson entity)
        {
            _physicalPersonRepository.AddOrUpdate(entity);
        }

        public void Dispose()
        {
        }

        public IEnumerable<PhysicalPerson> GetAll()
        {
            return _physicalPersonRepository.GetAll();
        }

        public async Task<IEnumerable<PhysicalPerson>> GetAllAsync()
        {
            return await _physicalPersonRepository.GetAllAsync();
        }

        public PhysicalPerson GetById(Guid id)
        {
            return _physicalPersonRepository.GetById(id);
        }

        public void Remove(PhysicalPerson entity)
        {
           _physicalPersonRepository.Remove(entity);
        }
    }
}
