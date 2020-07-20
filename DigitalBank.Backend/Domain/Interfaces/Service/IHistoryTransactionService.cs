using Domain.Entities;
using Domain.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IHistoryTransactionService: IService<HistoryTransaction>
    {
        Task<IEnumerable<HistoryTransaction>> GetAllByTypeAsync(EPaymentType type);

    }
}
