using BookStore.EntityCore.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.EntityCore.ContextConfigurations
{
    public class OrderEntityConfiguration : EntityTypeConfiguration<OrderEntity>
    {
        public OrderEntityConfiguration()
        {
            this.ToTable("Orders");

            this.HasKey(o => o.Id);
            this.Property(o => o.CustomerId)
                .IsRequired();
            this.Property(o => o.OrderDate).IsRequired();

            this.HasMany(o => o.OrderItems).WithRequired(oi => oi.Order).HasForeignKey(oi => oi.OrderId);


        }
    }
}
