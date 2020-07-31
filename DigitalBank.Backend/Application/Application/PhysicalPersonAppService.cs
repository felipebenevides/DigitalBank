using Application.Interfaces;
using Application.ViewModel;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Application
{
    public class PhysicalPersonAppService : IPhysicalPersonAppService
    {
        private readonly IMapper _mapper;
        private readonly IPhysicalPersonService _physicalPersonService;

        public PhysicalPersonAppService(IMapper mapper,
                                  IPhysicalPersonService physicalPersonService)
        {
            _mapper = mapper;
            _physicalPersonService = physicalPersonService;
        }

        public void AddBulk(IEnumerable<PhysicalPersonViewModel> entities)
        {
           var addCommand = _mapper.Map<IEnumerable<PhysicalPerson>>(entities);
            _physicalPersonService.AddBulk(addCommand);
        }

        public void AddOrUpdate(PhysicalPersonViewModel entity)
        {
          var addCommand =  _mapper.Map<PhysicalPerson>(entity);
            _physicalPersonService.AddOrUpdate(addCommand);
        }

     
        public IEnumerable<PhysicalPersonViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PhysicalPersonViewModel>>(_physicalPersonService.GetAll());
        }

        public async Task<IEnumerable<PhysicalPersonViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<PhysicalPersonViewModel>>(await _physicalPersonService.GetAllAsync());
        }

        public PhysicalPersonViewModel GetById(Guid id)
        {
            return _mapper.Map<PhysicalPerson,PhysicalPersonViewModel>( _physicalPersonService.GetById(id));
        }

        public void Remove(PhysicalPersonViewModel entity)
        {
            var removeCommand = _mapper.Map<PhysicalPersonViewModel, PhysicalPerson>(entity);
            _physicalPersonService.Remove(removeCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
