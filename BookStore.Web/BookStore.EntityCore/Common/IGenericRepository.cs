using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.EntityCore.Common
{
    public interface IGenericRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> AddAsync(TEntity model);
        Task DeleteAsync(int id);
        Task UpdateAsync(TEntity entity);
    }
}
