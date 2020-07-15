using Domain.Enum;
using System;

namespace Domain.Entities
{
    public class HistoryUser : BaseEntity, ITrackableEntity
    {
        public DateTime DateRequest { get; set; }
        public EStatus Status { get; set; }
        public bool HadComplaint { get; set; }

        //public int IdUserCar { get; set; } // Definir tabela...

        public int IdCustomerUser { get; set; }
        public CustomerUser CustomerUser{ get; set; }

        public int IdCustomerMechanical { get; set; }
        public CustomerMechanical CustomerMechanical { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
