using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class LegalPersonToLegalPersonViewModelMapping : Profile
    {
        public LegalPersonToLegalPersonViewModelMapping()
        {
            CreateMap<LegalPerson,LegalPersonViewModel>();
        }
    }
}
