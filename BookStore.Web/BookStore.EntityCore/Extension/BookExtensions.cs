using BookStore.Contract.Models;
using BookStore.EntityCore.Entity;

namespace BookStore.EntityCore.Extension
{
    public static class BookExtensions
    {
        public static BookModel ToModel(this BookEntity bookEntity)
        {
            var model = new BookModel()
            {
                Id = bookEntity.Id,
                Name = bookEntity.Name,
                PublishYear = bookEntity.PublishYear
            };
            return model;
        }
        public static BookEntity ToEntity(this BookModel bookEntity)
        {
            var entity = new BookEntity()
            {
                Name = bookEntity.Name,
                PublishYear = bookEntity.PublishYear
            };
            return entity;
        }
    }
}
