using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class PhysicalPersonViewModelToPhysicalPersonMapping : Profile
    {
        public PhysicalPersonViewModelToPhysicalPersonMapping()
        {
            CreateMap<PhysicalPersonViewModel, PhysicalPerson>();
        }
    }
}
