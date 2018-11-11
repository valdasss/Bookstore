using BookStore.Contract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contract.Interfaces.Services
{
    public interface IOrderService
    {
        Task<bool> AddOrderAsync(AddOrderModel model);
        Task<IEnumerable<OrderModel>> GetAllOrdersAsync();
        Task<IEnumerable<OrderModel>> GetOrdersByCustIdAsync(int id);
        Task<OrderDetailModel> GetOrderDetailsAsync(int id);
    }
}
