using BookStore.Contract.Interfaces.Services;
using BookStore.Contract.Models;
using BookStore.Web.Models.ViewModels;
using BookStore.Web.VMExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {

            _bookService = bookService;
        }


        public async Task<ActionResult> Index()
        {
            var books = await _bookService.getAllAsync();
            return View(books.Select(x=>x.ToViewModel()));
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(BookViewModel bookModel)
        {
            var result = await _bookService.AddBookAsync(bookModel.ToModel());
            if (result)
            {
                ViewBag.Result = "Sekmingai ivykdyta operacija";
            }
            else
            {
                ViewBag.Result = "Nesekmingai ivykdyta operacija";
            }
            return View();
        }
    }
}