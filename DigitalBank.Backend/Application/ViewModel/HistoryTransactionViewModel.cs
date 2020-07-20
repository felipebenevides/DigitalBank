using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class HistoryTransactionViewModel
    {
        public decimal Amount { get; set; }
        public decimal TransactionCost { get; set; }
        public DateTime TransactionDate { get; set; }
        public EPaymentType PaymentType { get; set; }

        public IList<CustomerHistoryTransactionViewModel> CustomerHistoryTransactions { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
