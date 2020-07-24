using Domain.Enum;
using System;

namespace Domain.Entities
{
    public class Account : BaseEntity, ITrackableEntity
    {
        public string Agency { get; set; }
        public string BankAccount { get; set; }
        public decimal BankBalance { get; set; }
        public EAccountType AccountType { get; set; }


        public Guid CardID { get; set; }
        public virtual Card Card { get; set; }

        public Guid? PhisicalPersonID { get; set; }
        public virtual PhysicalPerson PhisicalPerson { get; set; }
        public Guid? LegalPersonID { get; set; }
        public virtual LegalPerson LegalPerson { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
