using Application.Interfaces;
using Application.ViewModel;
using AutoMapper;
using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Application
{
    public class TransactionAppService :  ITransactionAppService
    {
        private readonly IMapper _mapper;
        private readonly IHistoryTransactionService _transactionService;

        public TransactionAppService(IMapper mapper,
                                      IHistoryTransactionService transactionService) 
        {
            _mapper = mapper;
            _transactionService = transactionService;
        }

        public void AddBulk(IEnumerable<HistoryTransactionViewModel> entities)
        {
            var addBulkCommand = _mapper.Map<IEnumerable<HistoryTransaction>>(entities);
            _transactionService.AddBulk(addBulkCommand);
        }

        public void AddOrUpdate(HistoryTransactionViewModel entity)
        {
            var addCommand = _mapper.Map<HistoryTransactionViewModel, HistoryTransaction>(entity);
            _transactionService.AddOrUpdate(addCommand);
        }

        public IEnumerable<HistoryTransactionViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<HistoryTransactionViewModel>>(_transactionService.GetAll());
        }

        public async Task<IEnumerable<HistoryTransactionViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<HistoryTransactionViewModel>>(await _transactionService.GetAllAsync());
        }

        public HistoryTransactionViewModel GetById(Guid id)
        {
            return _mapper.Map<HistoryTransactionViewModel>(_transactionService.GetById(id));
        }

        public void Remove(HistoryTransactionViewModel entity)
        {
            var removeCommand = _mapper.Map<HistoryTransaction>(entity);
            _transactionService.Remove(removeCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<HistoryTransactionViewModel>> GetAllByTypeAsync(string type)
        {
            var parseEnum = _mapper.Map<EPaymentType>(type);
            return _mapper.Map <IEnumerable<HistoryTransactionViewModel>>(await _transactionService.GetAllByTypeAsync(parseEnum));
        }
    }
}
