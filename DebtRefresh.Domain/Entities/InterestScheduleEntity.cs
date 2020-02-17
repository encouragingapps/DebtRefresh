using System;
using System.Collections.Generic;
using System.Text;

namespace DebtRefresh.Domain.Entities
{
    public class InterestScheduleEntity
    {
        public float InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}
