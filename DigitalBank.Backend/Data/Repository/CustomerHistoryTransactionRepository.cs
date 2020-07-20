using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class CustomerHistoryTransactionRepository:  Repository<CustomerHistoryTransaction>, ICustomerHistoryTransactionRepository
    {
        private readonly DigitalBankDBContext _digitalBankDBContext;
        public CustomerHistoryTransactionRepository(DigitalBankDBContext ctx): base(ctx)
        {
            _digitalBankDBContext = ctx;
        }
    }
}
