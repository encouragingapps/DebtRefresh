using DebtRefresh.Domain.Data.DatabaseTables;
using DebtRefresh.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtRefresh.Domain.Data
{
    public class SqliteContext : DbContext
    {
        public SqliteContext()
        {
            IntializeDB();
        }

        private void IntializeDB()
        {
            //Create the database if it does not exist
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Filename=./DebtRefreshDb.sqlite");
        }

        public DbSet<CreditCardTableData> CreditCards { get; set; }
        public DbSet<InterestRateTableData> InterestRates { get; set; }
    }
   
}
