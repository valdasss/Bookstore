using BookStore.Contract.Interfaces.Services;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRep;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRep = orderItemRepository;

        }
    }
}
