using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class AccountViewModel
    {
        public string Agency { get; set; }
        public string BankAccount { get; set; }
        public decimal BankBalance { get; set; }
        public EAccountType AccountType { get; set; }

        public Guid CardID { get; set; }
        public virtual CardViewModel Card { get; set; }
    }
}
