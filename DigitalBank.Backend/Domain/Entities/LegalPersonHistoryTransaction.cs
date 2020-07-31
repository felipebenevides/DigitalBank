using Domain.Enum;
using System;

namespace Domain.Entities
{
    public class LegalPersonHistoryTransaction : BaseEntity
    {
        public  Guid LegalPersonID { get; set; }
        public  LegalPerson LegalPerson { get; set; }
        public  Guid HistoryTransactionID { get; set; }
        public HistoryTransaction HistoryTransaction { get; set; }
    }
}
