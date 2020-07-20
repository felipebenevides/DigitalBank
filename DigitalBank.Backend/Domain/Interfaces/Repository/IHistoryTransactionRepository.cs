using Domain.Entities;
using System.Transactions;

namespace Domain.Interfaces.Repository
{
    public interface IHistoryTransactionRepository: IRepository<HistoryTransaction>
    {
    }
}
