using DebtRefresh.Domain.Data.DatabaseTables;
using DebtRefresh.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebtRefresh.Domain.Data
{
    public class CreditCardDbService
    {

        public static void Add(CreditCardTableData creditCard)
        {
            using var context = new SqliteContext();
            var entity = context.CreditCards.Add(creditCard);
            entity.State = EntityState.Added;
            context.SaveChanges();
        }

        public static void Edit(CreditCardTableData creditCard)
        {
            using var context = new SqliteContext();
            var entity = context.CreditCards.Update(creditCard);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public static void Delete(CreditCardTableData creditCard)
        {
            using var context = new SqliteContext();
            var entity = context.CreditCards.Remove(creditCard);
            entity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public static void GetAll()
        {
            using var context = new SqliteContext();
            if (context.CreditCards.Any())
            {
                var data = context.CreditCards.ToList();
                foreach (var creditcard in data)
                {
                    _ = creditcard.AccountNickName;
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
            if (context.CreditCards.Any())
            {
                var data = context.CreditCards.ToList();
                foreach (var product in data)
                {
                    context.CreditCards.Remove(product);
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
