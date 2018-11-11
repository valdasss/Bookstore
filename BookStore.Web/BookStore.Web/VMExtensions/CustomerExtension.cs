using BookStore.Contract.Models;
using BookStore.Web.Models.ViewModels;

namespace BookStore.Web.VMExtensions
{
    public static class CustomerExtension
    {
        public static CustomerViewModel ToViewModel(this CustomerModel customerModel)
        {
            var viewModel = new CustomerViewModel()
            {
                Id = customerModel.Id,
                FirstName = customerModel.FirstName,
                LastName = customerModel.LastName
            };
            return viewModel;
        }

        public static CustomerModel ToModel(this CustomerViewModel customerViewModel)
        {
            var viewModel = new CustomerModel()
            {
                Id = customerViewModel.Id,
                FirstName = customerViewModel.FirstName,
                LastName = customerViewModel.LastName
            };
            return viewModel;
        }

    }
}