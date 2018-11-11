using BookStore.EntityCore.Entity;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.EntityCore.ContextConfigurations
{
    public class CustomerEntityConfiguration : EntityTypeConfiguration<CustomerEntity>
    {
        public CustomerEntityConfiguration()
        {

            this.ToTable("Customers");

            this.HasKey<int>(c => c.Id);

            this.HasMany(c => c.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(s=>s.CustomerId);

            this.Property(c => c.FirstName).IsRequired();

            this.Property(c => c.LastName).IsRequired();

           

        }

    }
}
