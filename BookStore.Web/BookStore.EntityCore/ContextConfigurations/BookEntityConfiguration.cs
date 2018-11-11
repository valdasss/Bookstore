using BookStore.EntityCore.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.EntityCore.ContextConfigurations
{
    public class BookEntityConfiguration : EntityTypeConfiguration<BookEntity>
    {
        public BookEntityConfiguration()
        {

            this.ToTable("Books");

            this.HasKey(b => b.Id);

            this.Property(b => b.Name).IsRequired();
            this.Property(b => b.PublishYear).IsRequired();
            

            this.HasMany(b => b.OrderItems).WithRequired(oi => oi.Book).HasForeignKey(oi => oi.BookId);


        }
    }
}
