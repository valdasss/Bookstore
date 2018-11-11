using BookStore.Contract.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Contract.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<bool> AddCustomerAsync(CustomerModel customerModel);
        Task<IEnumerable<CustomerModel>> GetAllAsync();
        Task<IEnumerable<CustomerOrderCountModel>> GetAllWithOrderCountAsync();
        Task<IEnumerable<CustomerBooksModel>> GetAllWithTotalBookCountAsync();
        Task<IEnumerable<CustomerModel>> GetCustWithOutOrdersAsync();
    }
}
