using BookStore.Contract.Models;
using BookStore.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.VMExtensions
{
    public static class OrderExtension
    {
        public static AddOrderModel ToAddModel(this OrderVM orderVM)
        {
            var model = new AddOrderModel()
            {
                CustomerId = orderVM.CustomerId,
                OrderItems = orderVM.OrderItems.Select(x => x.ToModel())
            };
            return model;
        }

        public static OrderListVM ToViewModel (this OrderModel model)
        {
            var viewModel = new OrderListVM()
            {
                Id = model.Id,
                Date = model.Date,
                FullName = model.FullName
            };
            return viewModel;
        }
        public static OrderDetailVM ToDetailVM(this OrderDetailModel model)
        {
            var viewModel = new OrderDetailVM()
            {
                Id = model.Id,
                Date = model.Date,
                FullName = model.FullName,
                OrderItems =model.OrderItems.Select(x=>x.ToViewModel())
            };
            return viewModel;
        }

    }
}