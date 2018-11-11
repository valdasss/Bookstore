using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.Models.ViewModels
{
    public class OrderVM
    {
        public int CustomerId { get; set; }
        public IEnumerable<AddOrderItemVM> OrderItems { get; set; }
    }
}