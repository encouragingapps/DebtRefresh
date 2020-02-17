using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Enums;
using DebtRefresh.Domain.Entities;

namespace DebtRefresh.Domain.Interfaces
{
    public interface IFeeSchedule
    {
        public List<FeeScheduleEntity> FeeSchedules { get; set; }
    }
}
