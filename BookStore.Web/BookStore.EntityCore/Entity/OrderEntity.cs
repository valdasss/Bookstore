using System;
using System.Collections.Generic;

namespace BookStore.EntityCore.Entity
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
    }
}
