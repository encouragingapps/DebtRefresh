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
            LoadData();
        }

        public void LoadData()
        {

        }

        public float GetTotalConsumerDebt()
        {
            return ConsumerDebts.Sum(x => x.OwingBalance);
        }

        public float GetTotalConsumerDebt(Enums.ConsumerDebtEnums debtType)
        {
            return ConsumerDebts.Where(x => 
                                       x.ConsumerDebtType == debtType).Sum(
                                       x => x.OwingBalance);
        }
     
    }
}
