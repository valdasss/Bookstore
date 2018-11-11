using System.Data.Entity;
using System.Threading.Tasks;

namespace BookStore.EntityCore.Context
{
    public abstract class BaseBookStoreContext : DbContext
    {
        protected BaseBookStoreContext(string connection) : base(connection)
        {

        }
        public override async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
