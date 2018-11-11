using BookStore.EntityCore.Common;
using BookStore.EntityCore.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Repository.Interfaces
{
    public interface IOrderRepository : IGenericRepository<OrderEntity>
    {
        Task<IEnumerable<OrderEntity>> getAllOrderIncludeCustAsync();
        Task<IEnumerable<OrderEntity>> GetOrdersByCustIdAsync(int id);
        Task<OrderEntity> getOrderByIdIncludeCustAndItemsAsync(int id);

    }
}
