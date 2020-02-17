using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Entities;

namespace DebtRefresh.Domain.Interfaces
{
    public interface IInterestSchedule
    {
        public List<InterestScheduleEntity> InterestRates { get; set; }
    }
}
