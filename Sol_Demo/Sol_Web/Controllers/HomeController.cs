using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Web.Models;

namespace Sol_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CallCustomerModule()
        {
            TempData["CustomerData"] = "Hello From Home Controller";

            return RedirectToAction("Index", "Customer", new { Area = "CustomerModule" });
        }

        public IActionResult CallAdminModule()
        {
            TempData["AdminData"] = "Hello From Home Controller";

            return RedirectToAction("Index", "Admin", new { Area = "AdminModule" });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}