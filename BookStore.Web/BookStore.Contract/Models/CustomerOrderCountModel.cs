using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Contract.Models
{
    public class CustomerOrderCountModel
    {
        public string FullName { get; set; }
        public int OrderCount { get; set; }
    }
}
