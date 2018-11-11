using BookStore.Contract.Interfaces.Services;
using BookStore.Contract.Models;
using BookStore.EntityCore.Extension;
using BookStore.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRep;
        private readonly IOrderItemRepository _orderItemRep;

        public OrderService(IOrderRepository orderRepository, IOrderItemRepository orderItemRepository)
        {
            _orderRep = orderRepository;
            _orderItemRep = orderItemRepository;
        }

        public async Task<bool> AddOrderAsync(AddOrderModel model)
        {
            var result = await _orderRep.AddAsync(model.ToEntity());
            if (result != null)
            {
                foreach (var item in model.OrderItems)
                {
                    await _orderItemRep.AddAsync(item.ToEntity(result.Id));
                }
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<OrderModel>> GetAllOrdersAsync()
        {
            var orders = await _orderRep.getAllOrderIncludeCustAsync();
            return orders.Select(x => x.ToModel());
        }

        public async Task<OrderDetailModel> GetOrderDetailsAsync(int id)
        {
            var order = await _orderRep.getOrderByIdIncludeCustAndItemsAsync(id);
            return order.ToDetailModel();
        }

        public async Task<IEnumerable<OrderModel>> GetOrdersByCustIdAsync(int id)
        {
            var orders = await _orderRep.GetOrdersByCustIdAsync(id);
            return orders.Select(x => x.ToModel());
        }
    }
}