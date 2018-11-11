using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.Models.ViewModels
{
    public class OrderDetailVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<AddOrderItemVM> OrderItems { get; set; }
    }
}