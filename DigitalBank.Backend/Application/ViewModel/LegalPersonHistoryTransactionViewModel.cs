using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel
{
    public class LegalPersonHistoryTransactionViewModel
    {
        public Guid LegalPersonID { get; set; }
        public LegalPersonViewModel LegalPerson { get; set; }
        public Guid HistoryTransactionID { get; set; }
        public HistoryTransactionViewModel HistoryTransaction { get; set; }
    }
}
