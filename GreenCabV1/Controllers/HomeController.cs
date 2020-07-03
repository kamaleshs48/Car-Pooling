using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreenCabV1.Models;
using System.Configuration;
using GreenCabV1.Repository;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Cors;

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
            return RedirectToAction("csr", "Home");
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

            return RedirectToAction("corporate-carpool");

            // return View();
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

            if (!Captcha.ValidateCaptchaCode(models.CaptchaCode, HttpContext))
            {
                ModelState.AddModelError("CaptchaCode", "");
                return View("corporate-carpool", models);

            }


            int a = _Common.SaveCorporateCarpool(models);

            if (a > 0)
            {
                //Send Email

                string Message = "";

                Message += "Hi Team,<br/>" + " Green Car Query Submited details are below.<br/>";
                Message += "<string>Name:-</strong>" + models.Name + "<br/>";
                Message += "<string>EMail:-</strong>" + models.Email + "<br/>";

                Message += "<string>Contact Number:-</strong>" + models.Phone + "<br/>";

                Message += "<string>Message:-</strong>" + models.Comments + "";
                CommonFunction.SendMail("GreenCar | Contact Us Details", Message, "rajivarora2014@gmail.com");
                CommonFunction.SendMail("GreenCar | Contact Us Details", Message, "greencarcarpool@gmail.com");


                return RedirectToAction("thanks", "Home");
            }

            return View("corporate-carpool");

        }
        [Route("get-captcha-image")]
        public IActionResult GetCaptchaImage()
        {
            try

            {
                int width = 100;
                int height = 36;
                var captchaCode = Captcha.GenerateCaptchaCode();
                var result = Captcha.GenerateCaptchaImage(width, height, captchaCode);
                HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
                Stream s = new MemoryStream(result.CaptchaByteData);
                return new FileStreamResult(s, "image/png");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpPost]
        public JsonResult SaveCarOwnerDetails(string Name, string MobileNo, string City)
        {
            _Common.SaveCarOwnerDetails(Name, MobileNo, City);
            return Json(" Thanks.. for showing intrerest in Green Car. We will get back to you");
        }


        [HttpPost]
        public JsonResult SaveOddEvenDetails(string Name, string MobileNo, string Email, string ORG, string Comments)
        {


            CorporateCarpoolModels models = new CorporateCarpoolModels();
            models.Name = Name;
            models.Phone = MobileNo;
            models.Email = Email;
            models.Organization = ORG;
            models.Comments = Comments;
            models.Mode = "SaveOddEvenDetails";

            int a = _Common.SaveCorporateCarpool(models);


            string Message = "";

            Message += "Hi Team,<br/>" + "Odd Even  details are below.<br/>";
            Message += "<string>Name:-</strong>" + models.Name + "<br/>";
            Message += "<string>EMail:-</strong>" + models.Email + "<br/>";

            Message += "<string>Contact Number:-</strong>" + models.Phone + "<br/>";
            Message += "<string>Organization:-</strong>" + models.Organization + "<br/>";
            Message += "<string>Comments:-</strong>" + models.Comments + "<br/>";

            Message += "<string>Message:-</strong>" + models.Comments + "";
            CommonFunction.SendMail("GreenCar | Odd Even Details", Message, "rajivarora2014@gmail.com");
            CommonFunction.SendMail("GreenCar | Odd Even Details", Message, "greencarcarpool@gmail.com");





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

        public IActionResult Test()
        {
            return View();
        }

        [HttpPost]
        [EnableCors("AllowOrigin")]
        public JsonResult AjaxMethod1(PersonModel person)
        {
            person.DateTime = DateTime.Now.ToString();
            return Json(person);
        }



        [HttpPost]
        [EnableCors("AllowOrigin")]
        public JsonResult AjaxMethod([FromBody]EliteContatusModels models)
        {
            //person.DateTime = DateTime.Now.ToString();


            try
            {

                int a = _Common.SaveCorporateCarpool(new CorporateCarpoolModels
                {
                    Name = models.Name,
                    Organization = models.Organization,
                    Mode = "Save",
                    Email = models.Email,
                    Comments = models.Comments,

                }
                    );

                if (a > 0)
                {
                    //Send Email

                    string Message = "";

                    Message += "Hi Team,<br/>" + " Elitecorporatesolutions Query Submited details are below.<br/>";
                    Message += "<string>Name:-</strong>" + models.Name + "<br/>";
                    Message += "<string>EMail:-</strong>" + models.Email + "<br/>";

                    Message += "<string>Contact Number:-</strong>" + models.Phone + "<br/>";
                    Message += "<string>Subject :-</strong>" + models.Organization + "<br/>";

                    Message += "<string>Message:-</strong>" + models.Comments + "";
                    CommonFunction.SendMail("GreenCar | Contact Us Details", Message, "rajivarora2014@gmail.com");
                    CommonFunction.SendMail("GreenCar | Contact Us Details", Message, "greencarcarpool@gmail.com");

                    return Json(models);

                    //  return RedirectToAction("thanks", "Home");
                }
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
            return Json("Error");





        }


    }
}