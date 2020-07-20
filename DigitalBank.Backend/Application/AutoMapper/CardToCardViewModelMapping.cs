using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class CardToCardViewModelMapping : Profile
    {
        public CardToCardViewModelMapping()
        {
            CreateMap<Card, CardViewModel>();
        }
    }
}
