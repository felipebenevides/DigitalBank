using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITransactionAppService : IAppService<HistoryTransactionViewModel>
    {
        Task<IEnumerable<HistoryTransactionViewModel>> GetAllByTypeAsync(string type);
    }
}
