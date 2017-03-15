using Microsoft.EntityFrameworkCore;
using MyCashApi.Entities;

namespace MyCashApi.Infrastructure
{
    public class Ctx : DbContext
    {
        public Ctx(DbContextOptions<Ctx> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BudgetEntry> BudgetEntries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

    }
}