using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Interfaces;

namespace DebtRefresh.Domain.Entities
{
    public class CreditCardRewardsEntity : IRewards
    {
        public int PointsEarned { get; set; }
        public float DollarAmountPerPointValue { get; set; }
    }
}
