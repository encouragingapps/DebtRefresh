using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Enums;
using DebtRefresh.Domain.Entities;

namespace DebtRefresh.Domain.Interfaces 
{
    public interface IDueDateSchedule
    {
        public List<DueDateScheduleEntity> DueDateSchedule { get; set; }
    }
}
