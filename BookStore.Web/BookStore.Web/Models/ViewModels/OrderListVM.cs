using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.Models.ViewModels
{
    public class OrderListVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
    }
}