using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DebtRefresh.Domain.Interfaces;
using DebtRefresh.Domain.Data.DatabaseTables;
using DebtRefresh.Domain.Data.DbService;
using DebtRefresh.Domain.Models;

namespace DebtRefresh.Domain.BusinessLogic
{
    //https://www.newtonsoft.com/json/help/html/SerializingJSON.htm
    public class CreditCardDebtBL
    {
                
        public CreditCardDebtBL()
        {
           
        }

        public void LoadData()
        {

        }

        //Change this to IConsumerDebt
        public void SaveData(CreditCardModel ccData)
        {

            var ccTableData = new CreditCardTableData
            {
                VendorName = ccData.CardVendor,
                AccountNickName = ccData.CardNickname,
                CreditCardType = ccData.CardType,
                OwingBalance = ccData.CardBalance,
                CreditLine = ccData.CardBalance
            };

            int CreditCardId = CreditCardDbService.Add(ccTableData);

            foreach (InterestRateModel item in ccData.InterestRates)
            {
                var interestData = new InterestRateTableData
                {
                    CreditCardFK = CreditCardId,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    InterestRate = item.InterestRate
                };

                InterestRateDbService.Add(interestData);
                
            }

        }

        //public float GetTotalConsumerDebt()
        //{
        //    return ConsumerDebts.Sum(x => x.OwingBalance);
        //}

        //public float GetTotalConsumerDebt(Enums.ConsumerDebtEnums debtType)
        //{
        //    return ConsumerDebts.Where(x => 
        //                               x.ConsumerDebtType == debtType).Sum(
        //                               x => x.OwingBalance);
        //}
     
    }
}
