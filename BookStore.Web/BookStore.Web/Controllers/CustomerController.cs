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
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerServ;
        public CustomerController(ICustomerService customerService)
        {
            _customerServ = customerService;
        }
        // GET: Customer
        public async Task<ActionResult> Index()
        {
            var customers = await _customerServ.GetAllAsync();
            return View(customers.Select(x=>x.ToViewModel()));
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CustomerViewModel customerViewModel)
        {
            var result = await _customerServ.AddCustomerAsync(customerViewModel.ToModel());
            if (result)
                ViewBag.Result = "Operacija sėkiminga";
            else
                ViewBag.Result = "Operacija nesėkminga";
            return View();
        }
    }
}