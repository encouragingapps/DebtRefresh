using DebtRefresh.Domain.Data.DatabaseTables;
using DebtRefresh.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebtRefresh.Domain.Data
{
    public class InterestRateDbService
    {

        public static void Add(InterestRateTableData interestRate)
        {
            using var context = new SqliteContext();
            var entity = context.InterestRates.Add(interestRate);
            entity.State = EntityState.Added;
            context.SaveChanges();
        }

        public static void Edit(InterestRateTableData interestRate)
        {
            using var context = new SqliteContext();
            var entity = context.InterestRates.Update(interestRate);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public static void Delete(InterestRateTableData interestRate)
        {
            using var context = new SqliteContext();
            var entity = context.InterestRates.Remove(interestRate);
            entity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public static void GetAll()
        {
            using var context = new SqliteContext();
            if (context.CreditCards.Any())
            {
                var data = context.InterestRates.ToList();
                foreach (var rate in data)
                {
                    _ = rate.InterestRate;
                }
            }
            else
            {
                //Console.WriteLine("No credit cards found");
            }
        }

        public static void ResetData()
        {
            using var context = new SqliteContext();
            if (context.InterestRates.Any())
            {
                var data = context.InterestRates.ToList();
                foreach (var rate in data)
                {
                    context.InterestRates.Remove(rate);
                }

                context.SaveChanges();

            }
        }

        public static CreditCardTableData Get(int Id)
        {
            using var context = new SqliteContext();
            var creditCard = context.CreditCards.Find(Id);
            
            return creditCard;

        }
    }
}
