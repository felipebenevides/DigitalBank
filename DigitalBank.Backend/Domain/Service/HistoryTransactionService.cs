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
        private readonly ILegalPersonRepository _legalPersonRepository;
        private readonly IPhysicalPersonRepository _physicalPersonRepository;

        public HistoryTransactionService(IHistoryTransactionRepository transactionRepository,
                                         ILegalPersonRepository legalPersonRepositor,
                                         IPhysicalPersonRepository physicalPersonRepository
                                         )
        {
            _transactionRepository = transactionRepository;
            _physicalPersonRepository = physicalPersonRepository;
            _legalPersonRepository = legalPersonRepositor;
        }

        public void AddBulk(IEnumerable<HistoryTransaction> entities)
        {
            _transactionRepository.AddBulk(entities);
        }

        private bool ValidateTransaction()
        {
            return true;
        }



        private decimal CalcPercent(decimal currentValue, int percent)
        {
            double calcPercent = ((double)percent / 100) * 300;
            decimal newCurrentValue = currentValue - (decimal)calcPercent;
            return newCurrentValue;
        }

        private decimal ApplyDiscount(decimal currentValue, EAccountType enAccountType)
        {
            decimal newCurrentValue = 0;
            
            switch (enAccountType)
            {
                case EAccountType.ContaCorrente:
                    newCurrentValue = CalcPercent(currentValue, 2);
                    break;
                case EAccountType.ContaEmpresarial:
                    newCurrentValue = CalcPercent(currentValue, 5);
                    break;
            }

            return newCurrentValue;

        }
        public void AddOrUpdate(HistoryTransaction entity)
        {
            //entity.Amount = ApplyDiscount(entity.Amount, entity.CustomerHistoryTransactions.Select(s => s.LegalPerson.AccountType).FirstOrDefault());
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
