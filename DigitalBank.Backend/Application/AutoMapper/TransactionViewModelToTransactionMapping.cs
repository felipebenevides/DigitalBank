using Application.ViewModel;
using AutoMapper;
using Domain.Entities;
using System.Transactions;

namespace Application.AutoMapper
{
    public class TransactionViewModelToTransactionMapping : Profile
    {
        public TransactionViewModelToTransactionMapping()
        {
            CreateMap<HistoryTransactionViewModel,HistoryTransaction>();
        }
    }
}
