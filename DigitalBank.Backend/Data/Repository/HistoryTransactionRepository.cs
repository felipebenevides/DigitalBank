using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class HistoryTransactionRepository: Repository<HistoryTransaction>, IHistoryTransactionRepository
    {
        public HistoryTransactionRepository(DigitalBankDBContext ctx) : base(ctx)
        {

        }
    }
}
