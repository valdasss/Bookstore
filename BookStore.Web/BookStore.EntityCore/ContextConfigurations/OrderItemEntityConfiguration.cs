using BookStore.EntityCore.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.EntityCore.ContextConfigurations
{
    public class OrderItemEntityConfiguration : EntityTypeConfiguration<OrderItemEntity>
    {
        public OrderItemEntityConfiguration()
        {
            this.ToTable("OrderItems");
            this.HasKey(oi => new { oi.OrderId, oi.BookId });
            this.Property(oi => oi.Quantity).IsRequired();

        }
    }
}
