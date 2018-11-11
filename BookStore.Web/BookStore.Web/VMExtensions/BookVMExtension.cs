using BookStore.Contract.Models;
using BookStore.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.VMExtensions
{
    public static class BookVMExtension
    {
        public static BookModel ToModel(this BookViewModel bookViewModel)
        {
            var model = new BookModel()
            {
                Name = bookViewModel.Name,
                PublishYear = bookViewModel.PublishDate
            };

            return model;
        }

        public static BookViewModel ToViewModel(this BookModel bookModel)
        {
            var viewModel = new BookViewModel()
            {
                Id = bookModel.Id,
                Name = bookModel.Name,
                PublishDate = bookModel.PublishYear
            };

            return viewModel;
        }
        public static AddOrderItemVM ToOrderItemVM(this BookModel bookModel)
        {
            var viewModel = new AddOrderItemVM()
            {
                Id = bookModel.Id,
                Name = bookModel.Name,
                PublishDate = bookModel.PublishYear
            };

            return viewModel;
        }
    }
}