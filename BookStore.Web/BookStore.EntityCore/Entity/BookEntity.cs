using System;
using System.Collections.Generic;

namespace BookStore.EntityCore.Entity
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishYear { get; set; }

        public virtual ICollection<OrderItemEntity> OrderItems { get; set; }
    }
}
