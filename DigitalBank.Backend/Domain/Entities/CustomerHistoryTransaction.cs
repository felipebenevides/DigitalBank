using Domain.Enum;
using System;

namespace Domain.Entities
{
    public class CustomerHistoryTransaction : BaseEntity
    {
        public virtual PhysicalPerson PhysicalPerson { get; set; }
        public virtual LegalPerson LegalPerson { get; set; }
        public virtual HistoryTransaction HistoryTransaction { get; set; }
    }
}
