using BookStore.Contract.Interfaces;
using BookStore.EntityCore.Common;
using BookStore.EntityCore.Entity;
using BookStore.Repository.Interfaces;
using System.Data.Entity;

namespace BookStore.Repository.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItemEntity>, IOrderItemRepository
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<OrderItemEntity> _dbSet;
        private DbContext Context => (DbContext)_dbContext;


        public OrderItemRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = Context.Set<OrderItemEntity>();
        }
    }
}
