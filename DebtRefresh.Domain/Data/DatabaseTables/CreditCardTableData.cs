using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DebtRefresh.Domain.Data.DatabaseTables
{
    public class CreditCardTableData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreditCardId { get; set; }
        public int CreditCardType { get; set; }
        public string VendorName { get; set; }
        public string AccountNickName { get; set; }
        public float CreditLine { get; set; }
        public float OwingBalance { get; set; }        
        public ICollection<InterestRateTableData> InterestRates { get; set; }

    }
}
