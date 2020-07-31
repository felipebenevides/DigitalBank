using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class LegalPersonViewModelToLegalPersonMapping : Profile
    {
        public LegalPersonViewModelToLegalPersonMapping()
        {
            CreateMap<LegalPersonViewModel,LegalPerson>();
        }
    }
}
