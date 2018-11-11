using BookStore.Contract.Interfaces.Services;
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
    public class OrderController : Controller
    {
        private readonly IOrderService _orderServ;
        private readonly ICustomerService _customerServ;
        private readonly IBookService _bookServ;
        public OrderController(IOrderService orderService,ICustomerService customerService,IBookService bookService)
        {
            _orderServ = orderService;
            _customerServ = customerService;
            _bookServ = bookService;
        }
        // GET: Order
        public async Task<ActionResult> Index()
        {
            var orders = await _orderServ.GetAllOrdersAsync();

            return View(orders.Select(x=>x.ToViewModel()));
        }

        public async Task<ActionResult> Create()
        {
            var customers = await _customerServ.GetAllAsync();
            var custDropDownList = customers.Select(x =>
              new {
                  CustomerId = x.Id,
                  FullName = string.Format("{0} {1}", x.FirstName, x.LastName)
              });

            ViewBag.CustomerList = new SelectList(custDropDownList, "CustomerId", "FullName");
            var books = await _bookServ.getAllAsync();
            var orderVM = new OrderVM();
            orderVM.OrderItems = books.Select(x => x.ToOrderItemVM());
            return View(orderVM);
        }
        [HttpPost]
        public async Task<ActionResult> Create(OrderVM orderVM)
        {
            var result = await _orderServ.AddOrderAsync(orderVM.ToAddModel());
            var customers = await _customerServ.GetAllAsync();
            var custDropDownList = customers.Select(x =>
              new {
                  CustomerId = x.Id,
                  FullName = string.Format("{0} {1}", x.FirstName, x.LastName)
              });

            ViewBag.CustomerList = new SelectList(custDropDownList, "CustomerId", "FullName");
            if(result)
            return Json(new { success = "Sekminga operacija" });
            else
                return Json(new { error = ""});
        }

        public async Task<ActionResult> Details(int id)
        {
            var order = await _orderServ.GetOrderDetailsAsync(id);

            return View(order.ToDetailVM());
        }
    }
}