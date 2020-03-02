using System;
using System.Collections.Generic;
using System.Text;

namespace DebtRefresh.Domain.Data.DatabaseTables
{
    public class InterestRateTableData
    {
        public int InterestRateId { get; set; }
        public float InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
