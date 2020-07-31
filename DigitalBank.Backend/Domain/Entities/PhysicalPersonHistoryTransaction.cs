using System;

namespace Domain.Entities
{
    public class PhysicalPersonHistoryTransaction : BaseEntity
    {
        public  Guid PhysicalPersonID { get; set; }
        public  PhysicalPerson PhysicalPerson { get; set; }
        public Guid HistoryTransactionID { get; set; }
        public  HistoryTransaction HistoryTransaction { get; set; }
    }
}
