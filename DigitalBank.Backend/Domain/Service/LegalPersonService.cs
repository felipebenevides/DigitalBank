using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class LegalPersonService : ILegalPersonService

    {
        private readonly ILegalPersonRepository _legalPersonRepository;

        public LegalPersonService(ILegalPersonRepository legalPersonRepository) 
        {
            _legalPersonRepository = legalPersonRepository;
        }
        
        public void AddBulk(IEnumerable<LegalPerson> entities)
        {
            _legalPersonRepository.AddBulk(entities);
        }

        public void AddOrUpdate(LegalPerson entity)
        {
            _legalPersonRepository.AddOrUpdate(entity);
        }

        public void Dispose()
        {
        }

        public IEnumerable<LegalPerson> GetAll()
        {
            return _legalPersonRepository.GetAll();
        }

        public async Task<IEnumerable<LegalPerson>> GetAllAsync()
        {
            return await _legalPersonRepository.GetAllAsync();
        }

        public LegalPerson GetById(Guid id)
        {
            return _legalPersonRepository.GetById(id);
        }

        public void Remove(LegalPerson entity)
        {
            _legalPersonRepository.Remove(entity);        
        }
    }
}
