using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class PhysicalPersonToPhysicalPersonViewModelMapping : Profile
    {
        public PhysicalPersonToPhysicalPersonViewModelMapping()
        {
            CreateMap<PhysicalPerson,PhysicalPersonViewModel>();
        }
    }
}
