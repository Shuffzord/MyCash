using MyCashApi.Entities;

namespace MyCashApi.Infrastructure.Repositories
{
    public class TransactionRepository : BaseRepository<Transaction>
    {
        public TransactionRepository(Ctx ctx) : base(ctx)
        {
        }
    }
}