using BookStore.Contract.Interfaces.Services;
using BookStore.Contract.Models;
using BookStore.EntityCore.Extension;
using BookStore.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Services
{


    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRep;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRep = customerRepository;
         
        }

        public async Task<bool> AddCustomerAsync(CustomerModel customerModel)
        {
            var custEntity = await _customerRep.AddAsync(customerModel.ToEntity());
            return custEntity != null ? true : false;
        }

        public async Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            var customers = await _customerRep.GetAllAsync();
            return customers.Select(x => x.ToModel());
        }

        public async Task<IEnumerable<CustomerOrderCountModel>> GetAllWithOrderCountAsync()
        {
            var customers = await _customerRep.GetAllIncludeOrders();
            var result = customers.Select(x => {
               return new CustomerOrderCountModel()
                {
                    FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                    OrderCount = x.Orders.Count
                };
               
            }).OrderByDescending(x=>x.OrderCount);
            return result;
        }

        public async Task<IEnumerable<CustomerBooksModel>> GetAllWithTotalBookCountAsync()
        {
            var customers = await _customerRep.GetAllIncludeOrders();
            var result = customers.Select(x => {
                return new CustomerBooksModel()
                {
                    FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                    BookCount = x.Orders.Sum(o => o.OrderItems.Sum(oi => oi.Quantity))
                };
            });
            return result;
        }

        public async Task<IEnumerable<CustomerModel>> GetCustWithOutOrdersAsync()
        {
            var customers = await _customerRep.GetCustomersWithOutOrdersAsync();
            return customers.Select(x => x.ToModel());
        }
    }
}
