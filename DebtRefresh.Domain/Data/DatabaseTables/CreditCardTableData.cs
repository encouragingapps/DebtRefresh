using System;
using System.Collections.Generic;
using System.Text;

namespace DebtRefresh.Domain.Data.DatabaseTables
{
    public class CreditCardTableData
    {
        public int CreditCardTableId { get; set; }
        public int CreditCardType { get; set; }
        public string AccountNickName { get; set; }
        public float CreditLine { get; set; }
        public float OwingBalance { get; set; }
    }
}
