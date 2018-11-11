using BookStore.Contract.Interfaces.Services;
using BookStore.Web.VMExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.Controllers
{
    public class ReportController : Controller
    {

        private readonly IOrderService _orderServ;
        private readonly ICustomerService _custServ;

        public ReportController(IOrderService orderService, ICustomerService customerService)
        {
            _orderServ = orderService;
            _custServ = customerService;

        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetOrdersByCustId(int custId)
        {
            var orders = await _orderServ.GetOrdersByCustIdAsync(custId);
            return Json(orders.Select(x => x.ToViewModel()), JsonRequestBehavior.AllowGet);
            
        }
        public async Task<JsonResult> GetCustomersWithoutOrders()
        {
            var customers = await _custServ.GetCustWithOutOrdersAsync();
            return Json(customers.Select(x => x.ToViewModel()), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> GetCustomersWithOrderCount()
        {
            var customers = await _custServ.GetAllWithOrderCountAsync();
            return Json(customers, JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> GetCustomersWithBooksCount()
        {
            var customers = await _custServ.GetAllWithTotalBookCountAsync();
            return Json(customers, JsonRequestBehavior.AllowGet);
        }
    }
}