using DebtRefresh.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtRefresh.Domain.Interfaces
{
    public interface IConsumerDebt
    {
        public string VendorName { get; set; }
        public string AccountNickName { get; set; }
        public float CreditLine { get; set; }
        public float OwingBalance { get; set; }
        public IInterestSchedule InterestRates { get; set; }
        //public IFeeSchedule FeeSchedule { get; set; }
        //public IDueDateSchedule DueDateSchedule { get; set; }
        //public ConsumerDebtEnums ConsumerDebtType { get; set; }
    }
}
