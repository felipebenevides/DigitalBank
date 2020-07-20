using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class HistoryTransactionService : IHistoryTransactionService
    {
        private readonly IHistoryTransactionRepository _transactionRepository;
        public HistoryTransactionService(IHistoryTransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public void AddBulk(IEnumerable<HistoryTransaction> entities)
        {
            _transactionRepository.AddBulk(entities);
        }

        public void AddOrUpdate(HistoryTransaction entity)
        {
            _transactionRepository.AddOrUpdate(entity);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<HistoryTransaction> GetAll()
        {
            return _transactionRepository.GetAll();
        }

        public async Task<IEnumerable<HistoryTransaction>> GetAllAsync()
        {
            return await _transactionRepository.GetAllAsync();
        }

        public async Task<IEnumerable<HistoryTransaction>> GetAllByTypeAsync(EPaymentType type)
        {
            var result = await _transactionRepository.GetAllAsync();

            return result.Where(w => w.PaymentType == type);
        }

        public HistoryTransaction GetById(Guid id)
        {
            return _transactionRepository.GetById(id);
        }

        public void Remove(HistoryTransaction entity)
        {
            _transactionRepository.Remove(entity);
        }
    }
}
