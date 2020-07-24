using Domain.Enum;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class HistoryTransaction : BaseEntity, ITrackableEntity
    {
        public decimal Amount { get; set; }
        public decimal TransactionCost { get; set; }
        public DateTime TransactionDate { get; set; }
        public EPaymentType PaymentType { get; set; }

        public virtual ICollection<LegalPersonHistoryTransaction> LegalPersonHistoryTransaction { get; set; }
        public virtual ICollection<PhysicalPersonHistoryTransaction> PhysicalPersonHistoryTransaction { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
