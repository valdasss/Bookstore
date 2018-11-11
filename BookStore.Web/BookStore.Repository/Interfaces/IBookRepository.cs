using BookStore.EntityCore.Common;
using BookStore.EntityCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Interfaces
{
    public interface IBookRepository : IGenericRepository<BookEntity>
    {
    }
}
