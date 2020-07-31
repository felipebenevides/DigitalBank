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
    public class LegalPersonAppService : ILegalPersonAppService
    {
        private readonly IMapper _mapper;
        private readonly ILegalPersonService _legaPersonService;

        public LegalPersonAppService(IMapper mapper,
                                  ILegalPersonService LegalPersonService)
        {
            _mapper = mapper;
            _legaPersonService = LegalPersonService;
        }

        public void AddBulk(IEnumerable<LegalPersonViewModel> entities)
        {
           var addCommand = _mapper.Map<IEnumerable<LegalPerson>>(entities);
            _legaPersonService.AddBulk(addCommand);
        }

        public void AddOrUpdate(LegalPersonViewModel entity)
        {
          var addCommand =  _mapper.Map<LegalPerson>(entity);
            _legaPersonService.AddOrUpdate(addCommand);
        }

     
        public IEnumerable<LegalPersonViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<LegalPersonViewModel>>(_legaPersonService.GetAll());
        }

        public async Task<IEnumerable<LegalPersonViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<LegalPersonViewModel>>(await _legaPersonService.GetAllAsync());
        }

        public LegalPersonViewModel GetById(Guid id)
        {
            return _mapper.Map<LegalPerson,LegalPersonViewModel>( _legaPersonService.GetById(id));
        }

        public void Remove(LegalPersonViewModel entity)
        {
            var removeCommand = _mapper.Map<LegalPersonViewModel, LegalPerson>(entity);
            _legaPersonService.Remove(removeCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
