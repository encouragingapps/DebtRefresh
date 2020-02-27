using System;

namespace DebtRefresh.WebUI.Models
{
    public class CreditCardModel
    {        
        public string CardVendor { get; set; }        
        public string CardNickname { get; set; }
        public string CardType { get; set; }
        public string CardLimit { get; set; }
        public string CardBalance { get; set; }
    }
}
