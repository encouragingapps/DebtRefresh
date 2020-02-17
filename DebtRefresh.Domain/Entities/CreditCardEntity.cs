using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Interfaces;
using DebtRefresh.Domain.Enums;

//TODO: Add rewards
namespace DebtRefresh.Domain.Entities
{    
    public class CreditCardEntity : IConsumerDebt, IRewards
    {
        public CreditCardEntity(IInterestSchedule rates,
                                IFeeSchedule fees,
                                IDueDateSchedule duedates)
        {
            InterestRates = rates;
            FeeSchedule = fees;
            DueDateSchedule = duedates;
        }

        public string VendorName { get; set; }
        public string AccountNickName { get; set; }
        public ConsumerDebtEnums ConsumerDebtType {get; set;}
        public float CreditLine { get; set; }
        public float OwingBalance { get; set; }
        public IInterestSchedule InterestRates { get; set; }    
        public IFeeSchedule FeeSchedule { get; set; }
        public IDueDateSchedule DueDateSchedule { get; set; }
        public int PointsEarned { get; set; }
        public float DollarAmountPerPointValue { get; set; }

        public float CreditAvailable()
        {
            return (CreditLine - OwingBalance);
        }

    }
}

