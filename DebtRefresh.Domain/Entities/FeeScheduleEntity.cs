using System;
using System.Collections.Generic;
using System.Text;
using DebtRefresh.Domain.Enums;
using DebtRefresh.Domain.Interfaces;

namespace DebtRefresh.Domain.Entities
{
    public class FeeScheduleEntity
    {
        public float FeeAmount { get; set; }
        public FeeScheduleEnums FeeType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
