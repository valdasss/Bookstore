using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contract.Models
{
    public class AddOrderModel
    {
        public int CustomerId { get; set; }
        public IEnumerable<OrderItemModel> OrderItems { get; set; }
    }
}
