using BookStore.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Contract.Interfaces.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookModel>> getAllAsync();
        Task<bool> AddBookAsync(BookModel bookModel);
    }
}
