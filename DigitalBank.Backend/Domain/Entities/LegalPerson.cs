using Domain.Enum;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class LegalPerson : BaseEntity, ITrackableEntity
    {
        public Guid AccountID { get; set; }
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public string Telephone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string DigitalPassword { get; set; }

        public EAccountType AccountType { get; set; }

        public DateTime RegistrationDate { get; set; }
        public bool Inative { get; set; }
        public DateTime DateInative { get; set; }
        public bool Deleted { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<LegalPersonHistoryTransaction> LegalPersonHistoryTransaction { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
