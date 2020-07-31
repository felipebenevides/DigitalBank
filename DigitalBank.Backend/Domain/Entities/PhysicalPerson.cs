using Domain.Enum;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class PhysicalPerson : BaseEntity, ITrackableEntity
    {
        public Guid AccountID { get; set; }

        public string NickName { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string CPF { get; set; }
        public string Telephone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string DigitalPassword { get; set; }
        public EGender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }


        public DateTime RegistrationDate { get; set; }
        public bool Inative { get; set; }
        public DateTime? DateInative { get; set; }
        public bool Deleted { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<PhysicalPersonHistoryTransaction> PhysicalPersonHistoryTransaction { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
