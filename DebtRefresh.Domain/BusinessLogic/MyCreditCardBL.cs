using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DebtRefresh.Domain.Interfaces;

namespace DebtRefresh.Domain.BusinessLogic
{
    //https://www.newtonsoft.com/json/help/html/SerializingJSON.htm
    public class MyConsumerDebt
    {
        public List<IConsumerDebt> ConsumerDebts { get; set; }

        public MyConsumerDebt()
        {
            ConsumerDebts = new List<IConsumerDebt>();
        }

        public float GetTotalDebt()
        {
            return ConsumerDebts.Sum(x => x.OwingBalance);
        }
    }
}
