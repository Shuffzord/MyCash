using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyCashApi.Entities;

namespace MyCashApi.Infrastructure
{
    public static class DbInitializer
    {
        public static void Initialize(Ctx context)
        {
            context.Database.EnsureCreated();

            // Look for any Transactions.
            if (context.Transactions.Any())
            {
                return;   // DB has been seeded
            }

            var Transactions = new Transaction[]
            {
                new Transaction{Value = 1,Category = "CatA"},
                new Transaction{Value = 1,Category = "CatB"},
                new Transaction{Value = 1,Category = "CatC"},
                new Transaction{Value = 2,Category = "CatC"},
            };
            foreach (Transaction s in Transactions)
            {
                context.Transactions.Add(s);
            }
            context.SaveChanges();

        }
    }
}