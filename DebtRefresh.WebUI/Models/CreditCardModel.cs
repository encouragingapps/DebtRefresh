using System;
using System.Collections.Generic;
using DebtRefresh.WebUI.Interfaces;

namespace DebtRefresh.WebUI.Models
{
    public class CreditCardModel
    {
        CreditCardModel ()
        {
            InterestRates = new List<InterestRateModel>();
        }

        public string CardVendor { get; set; }
        public string CardNickname { get; set; }
        public string CardType { get; set; }
        public string CardLimit { get; set; }
        public string CardBalance { get; set; }
        public List<InterestRateModel> InterestRates { get; set; }
    }
}
