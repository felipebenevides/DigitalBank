using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class CardViewModelToCardMapping : Profile
    {
        public CardViewModelToCardMapping()
        {
            CreateMap<CardViewModel,Card>();
        }
    }
}
