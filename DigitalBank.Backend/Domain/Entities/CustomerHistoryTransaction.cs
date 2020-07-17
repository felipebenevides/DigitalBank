using Domain.Enum;
using System;

namespace Domain.Entities
{
    public class CustomerHistoryTransaction : BaseEntity
    {
        public virtual Customer Customer { get; set; }
        public virtual HistoryTransaction HistoryTransaction { get; set; }
    }
}
