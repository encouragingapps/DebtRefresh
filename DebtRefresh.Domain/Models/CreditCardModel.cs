using System;
using System.Collections.Generic;
using DebtRefresh.Domain.Interfaces;


namespace DebtRefresh.Domain.Models
{
    public class CreditCardModel
    {
        CreditCardModel ()
        {
            InterestRates = new List<InterestRateModel>();
        }

        public string CardVendor { get; set; } 
        public string CardNickname { get; set; }
        public int CardType { get; set; }
        public float CardLimit { get; set; }
        public float CardBalance { get; set; }
        public List<InterestRateModel> InterestRates { get; set; }
        
    }
}
