using BookStore.EntityCore.ContextConfigurations;
using BookStore.EntityCore.Entity;
using System.Data.Entity;

namespace BookStore.EntityCore.Context
{
    public class BookStoreContext : BaseBookStoreContext,IBookdStoreContext
    {
        public BookStoreContext() : base("BookStoreContext")
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
        public DbSet<BookEntity> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {          
            modelBuilder.Configurations.Add(new BookEntityConfiguration());
            modelBuilder.Configurations.Add(new CustomerEntityConfiguration());
            modelBuilder.Configurations.Add(new OrderEntityConfiguration());
            modelBuilder.Configurations.Add(new OrderItemEntityConfiguration());
        }

    }
}
