using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class LegalPersonViewModel
    {
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

        public EAccountType AccountType { get; set; }

        public DateTime RegistrationDate { get; set; }
        public bool Inative { get; set; }
        public DateTime? DateInative { get; set; }
        public bool Deleted { get; set; }

        public virtual CardViewModel Card { get; set; }
        public virtual IList<CustomerHistoryTransactionViewModel> CustomerHistoryTransactions { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
