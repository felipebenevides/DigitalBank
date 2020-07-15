using Domain.Enum;
using System;

namespace Domain.Entities
{
    public class CustomerUser : BaseEntity, ITrackableEntity
    {
        public string NickName { get; set; }
        public string FullName { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telephone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public EGender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool Inative { get; set; }
        public DateTime DateInative { get; set; }
        public bool Deleted { get; set; }

        //Cognito Properties
        public string Username { get; set; }
        //public DateTime CreatedAt { get; set; }
        public long? ParticipanteId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
