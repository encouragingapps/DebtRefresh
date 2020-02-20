using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Interfaces;
using DebtRefresh.Domain.Enums;

//TODO: Add rewards
namespace DebtRefresh.Domain.Entities
{    
    public class CreditCardEntity : IConsumerDebt
    {
        public CreditCardEntity()
        {
           
        }

        public string VendorName { get; set; }
        public CreditCardTypeEnum CreditCardType { get; set; }
        public string AccountNickName { get; set; }
        public ConsumerDebtEnums ConsumerDebtType {get; set;}
        public float CreditLine { get; set; }
        public float OwingBalance { get; set; }
        public IInterestSchedule InterestRates { get; set; }    
        public IFeeSchedule FeeSchedule { get; set; }
        public IDueDateSchedule DueDateSchedule { get; set; }
        public IRewards Rewards { get; set; }        

        public float CreditAvailable()
        {
            return (CreditLine - OwingBalance);
        }

    }
}

