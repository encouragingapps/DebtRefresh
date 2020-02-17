using System;
using System.Collections.Generic;
using System.Text;

namespace DebtRefresh.Domain.Interfaces
{
    public interface IRewards
    {
        public int PointsEarned { get; set; }
        public float DollarAmountPerPointValue { get; set; }
    }
}
