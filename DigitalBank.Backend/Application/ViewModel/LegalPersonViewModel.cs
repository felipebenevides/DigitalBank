using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class LegalPersonViewModel
    {
        public Guid AccountID { get; set; }
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public string Telephone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string DigitalPassword { get; set; }

        public DateTime RegistrationDate { get; set; }
        public bool Inative { get; set; }
        public DateTime? DateInative { get; set; }

        public virtual AccountViewModel Account { get; set; }
    }
}
