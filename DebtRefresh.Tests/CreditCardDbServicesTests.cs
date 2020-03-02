using DebtRefresh.Domain.Data.DatabaseTables;
using DebtRefresh.Domain.Data.DbService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DebtRefresh.Tests
{
    [TestClass]
    public class CreditCardDbServicesTests
    {
        [TestMethod]
        public void AddCreditCard()
        {
            var ccInfo = new CreditCardTableData()
            {
                CreditCardType = 1,
                VendorName = "Discover",
                AccountNickName = "My Rewards Card",
                CreditLine = 100,
                OwingBalance = 24.99f
            };

            int CreditCardId;
            CreditCardId = CreditCardDbService.Add(ccInfo);

            var ccRate1 = new InterestRateTableData()
            {
                StartDate = new DateTime(2019, 04, 30, 0, 0, 0),
                EndDate = new DateTime(2020, 04, 30, 0, 0, 0),
                InterestRate = 0.3f,     
                CreditCardFK = CreditCardId
            };

            InterestRateDbService.Add(ccRate1);

            var ccRate2 = new InterestRateTableData()
            {
                StartDate = new DateTime(2018, 04, 30, 0, 0, 0),
                EndDate = new DateTime(2019, 04, 30, 0, 0, 0),
                InterestRate = 0.2f,
                CreditCardFK = CreditCardId
            };

            InterestRateDbService.Add(ccRate2);

        }
    }
}
