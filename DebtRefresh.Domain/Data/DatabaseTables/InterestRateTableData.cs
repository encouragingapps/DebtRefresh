using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DebtRefresh.Domain.Data.DatabaseTables
{
    public class InterestRateTableData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InterestRateId { get; set; }
        public float InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("CreditCardFK")]
        public CreditCardTableData CreditCardTableData { get; set; }
        public int CreditCardFK { get; set; }
    }
}
