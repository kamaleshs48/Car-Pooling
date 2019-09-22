using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreenCabV1.Models;
using System.Configuration;
using GreenCabV1.Repository;
namespace GreenCabV1.Controllers
{
    public class HomeController : Controller
    {



        IComman _Common;

        public HomeController(IComman _ic)
        {
            _Common = _ic;
        }
        public IActionResult Index()
        {
            return RedirectToAction("carpool", "Home");
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


        [ActionName("carpool")]
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

        public IActionResult Thanks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetInTouch(CorporateCarpoolModels models)
        {
            int a = _Common.SaveCorporateCarpool(models);

            if (a > 0)
                return RedirectToAction("thanks", "Home");
            return View("corporate-carpool");

        }


        [HttpPost]
        public JsonResult SaveCarOwnerDetails(string Name, string MobileNo, string City)
        {
            _Common.SaveCarOwnerDetails(Name, MobileNo, City);
            return Json(" Thanks.. for showing intrerest in Green Car. We will get back to you");
        }


        public JsonResult SaveNewsLetter(string Email)
        {
            _Common.SaveNewLetterData(Email);
            return Json(" Thanks.. for showing intrerest in Green Car. We will get back to you");
        }


        [HttpPost]
        public IActionResult SaveContactUs(ContactUsModels models)
        {
            int a = _Common.SaveContactUsData(models);

            if (a > 0)
                return RedirectToAction("thanks", "Home");
            return View("corporate-carpool");

        }




        [HttpPost]
        [ActionName("carpool")]
        public IActionResult dailycarpool(DailyCabModels models)
        {

            int a = _Common.SaveDailyCarPool(models);

            if (a > 0)
                return RedirectToAction("thank-you", "Home");


            return View();

        }

        [ActionName("thank-you")]
        public IActionResult thankyou()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult terms()
        {
            return View();
        }
    }
}