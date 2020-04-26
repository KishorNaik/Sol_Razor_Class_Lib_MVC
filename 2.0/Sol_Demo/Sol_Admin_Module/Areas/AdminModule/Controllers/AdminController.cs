using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sol_Admin_Module.Areas.AdminModule.Controllers
{
    [Area("AdminModule")]
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Data = TempData["AdminData"] as string;

            return View();
        }

        public IActionResult CallCustomer()
        {
            TempData["CustomerData1"] = "Calling from Admin Controller";
            return RedirectToAction("Index", "Customer", new { Area = "CustomerModule" });
        }
    }
}