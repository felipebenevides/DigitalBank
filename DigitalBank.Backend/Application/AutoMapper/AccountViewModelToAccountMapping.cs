using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class AccountViewModelToAccountMapping : Profile
    {
        public AccountViewModelToAccountMapping()
        {
            CreateMap<AccountViewModel,Account>();
        }
    }
}
