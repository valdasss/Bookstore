using BookStore.Contract.Models;
using BookStore.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.VMExtensions
{
    public static class OrderItemExtension
    {
        public static OrderItemModel ToModel(this AddOrderItemVM viewModel)
        {
            var model = new OrderItemModel()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                PublishDate = viewModel.PublishDate,
                Quantity = viewModel.Quantity
            };
            return model;

        }
        public static AddOrderItemVM ToViewModel(this OrderItemModel model)
        {
            var viewModel = new AddOrderItemVM()
            {
                Id = model.Id,
                Name = model.Name,
                PublishDate = model.PublishDate,
                Quantity = model.Quantity
            };
            return viewModel;

        }
    }
}