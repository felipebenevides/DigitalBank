using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class CardViewModel
    {
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string ValidateCard { get; set; }
        public string PrintedNameCard { get; set; }
        public bool Inactive { get; set; }
        public DateTime InactiveDate { get; set; }
        public Guid AccountID { get; set; }
        public virtual AccountViewModel Account { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
