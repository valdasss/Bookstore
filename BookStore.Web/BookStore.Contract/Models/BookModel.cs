using System;

namespace BookStore.Contract.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishYear { get; set; }
    }
}
