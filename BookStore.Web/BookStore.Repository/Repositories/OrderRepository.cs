using BookStore.Contract.Interfaces;
using BookStore.EntityCore.Common;
using BookStore.EntityCore.Entity;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Repositories
{
    public class OrderRepository : GenericRepository<OrderEntity>, IOrderRepository
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<OrderEntity> _dbSet;
        private DbContext Context => (DbContext)_dbContext;

        public OrderRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = Context.Set<OrderEntity>();
        }

        public async Task<IEnumerable<OrderEntity>> getAllOrderIncludeCustAsync()
        {
            var orders = await _dbSet.Include(x => x.Customer).ToListAsync();
            return orders;
        }

        public async Task<OrderEntity> getOrderByIdIncludeCustAndItemsAsync(int Id)
        {
            var order = await _dbSet.Include(x=>x.OrderItems).Where(x=>x.Id==Id).FirstOrDefaultAsync();
            return order;
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersByCustIdAsync(int id)
        {
            var orders = await _dbSet.Include(x=>x.Customer).Where(x => x.CustomerId == id).ToListAsync();
            return orders;
        }
    }
}
