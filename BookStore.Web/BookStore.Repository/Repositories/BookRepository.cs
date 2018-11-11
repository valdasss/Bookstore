using BookStore.Contract.Interfaces;
using BookStore.EntityCore.Common;
using BookStore.EntityCore.Entity;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Repositories
{
    public class BookRepository : GenericRepository<BookEntity>,IBookRepository
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<BookEntity> _dbSet;
        private DbContext Context => (DbContext)_dbContext;


        public BookRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = Context.Set<BookEntity>();
        }
    }
}
