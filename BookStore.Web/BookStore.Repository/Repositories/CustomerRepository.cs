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
    public class CustomerRepository : GenericRepository<CustomerEntity>, ICustomerRepository
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<CustomerEntity> _dbSet;
        private DbContext Context => (DbContext)_dbContext;

        public CustomerRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = Context.Set<CustomerEntity>();

        }

        public async Task<IEnumerable<CustomerEntity>> GetCustomersWithOutOrdersAsync()
        {
            var customers = await _dbSet.Include(x => x.Orders).Where(x => x.Orders.Count() == 0).ToListAsync();
            return customers;
        }

        public async Task<IEnumerable<CustomerEntity>> GetAllIncludeOrders()
        {
            var customers = await _dbSet.Include(x => x.Orders).ToListAsync();
            return customers;
        }
    }
}
