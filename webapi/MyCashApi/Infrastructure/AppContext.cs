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

    }
}