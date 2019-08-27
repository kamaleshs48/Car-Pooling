using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreenCabV1.Models;

namespace GreenCabV1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult aboutus()
        {
            return View();
        }

        public IActionResult contactus()
        {
            return View();
        }

        [ActionName("corporate-carpool")]
        public IActionResult corporatecarpool()
        {
            return View();
        }

        public IActionResult csr()
        {
            return View();
        }


        [ActionName("daily-carpool")]
        public IActionResult dailycarpool()
        {
            return View();
        }


        [ActionName("greencar-benefits")]
        public IActionResult greencarbenefits()
        {
            return View();
        }
        [ActionName("greencar-csr")]
        public IActionResult greencarcsr()
        {
            return View();
        }

        [ActionName("how-it-work")]
        public IActionResult howitwork()
        {
            return View();
        }

        [ActionName("support")]
        public IActionResult support()
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
