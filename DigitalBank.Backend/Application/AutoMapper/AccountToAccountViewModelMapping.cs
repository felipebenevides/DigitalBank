using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class AccountToAccountViewModelMapping : Profile
    {
        public AccountToAccountViewModelMapping()
        {
            CreateMap<Account, AccountViewModel>();
        }
    }
}
