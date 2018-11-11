using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contract.Models
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<OrderItemModel> OrderItems { get; set; }
    }
}
