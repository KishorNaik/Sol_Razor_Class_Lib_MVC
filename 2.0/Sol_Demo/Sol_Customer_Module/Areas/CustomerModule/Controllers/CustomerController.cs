using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sol_Customer_Module.Areas.CustomerModule.Controllers
{
    [Area("CustomerModule")]
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Data = TempData["CustomerData"] as string;

            ViewBag.Data1 = TempData["CustomerData1"] as string;

            return View();
        }
    }
}