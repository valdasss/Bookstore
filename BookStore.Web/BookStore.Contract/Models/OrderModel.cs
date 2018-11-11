using System;

namespace BookStore.Contract.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
    }
}
