using Application.ViewModel;
using AutoMapper;
using Domain.Entities;
using System.Transactions;

namespace Application.AutoMapper
{
    public class TransactionToTransactionViewModelMapping : Profile
    {
        public TransactionToTransactionViewModelMapping()
        {
            CreateMap<HistoryTransaction,HistoryTransactionViewModel>();
        }
    }
}
