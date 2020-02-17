using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Enums;
using DebtRefresh.Domain.Interfaces;

namespace DebtRefresh.Domain.Entities
{
    public class DueDateScheduleEntity
    {
        public DateTime DueDate { get; set; }
        public DueDateScheduleEnum DueDateType { get; set; }       
    }
}
