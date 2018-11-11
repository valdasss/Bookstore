using BookStore.Contract.Interfaces.Services;
using BookStore.Contract.Models;
using BookStore.EntityCore.Extension;
using BookStore.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRep;

        public BookService(IBookRepository bookRepository)
        {
            _bookRep = bookRepository;
        }

        public async Task<bool> AddBookAsync(BookModel bookModel)
        {
            var result = await _bookRep.AddAsync(bookModel.ToEntity());
            return result != null ? true : false;          
        }

        public async Task<IEnumerable<BookModel>> getAllAsync()
        {
            var books = await _bookRep.GetAllAsync();
            return books.Select(x => x.ToModel());
        }
    }
}
