using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GreenCabV1.Models;
using GreenCabV1.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenCabV1.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private IAzureVideoStreamService _streamingService;


        IComman _Common;

        

        public VideoController(IAzureVideoStreamService streamingService, IComman _ic)
        {
            _streamingService = streamingService;
            _Common = _ic;
        }

        [HttpGet("GetVideo")]
        public async Task<FileStreamResult> GetVideo(string name)
        {
            var stream = await _streamingService.GetVideoByName(name);
            return new FileStreamResult(stream, "video/mp4");

            //var content = new FileStream("", FileMode.Open, FileAccess.Read, FileShare.Read);
            //var response = File(content, "application/octet-stream");
            //return response;

            //  return BadRequest();

        }


        [HttpGet("GeVideoByUrl")]
        public async Task<FileStreamResult> GeVideoByUrl(string URL, string Tocken)
        {
            DateTime dateTime = DateTime.ParseExact(CommonFunction.API_Key_Decrypt(Tocken), "ddMMyyyyHHmm", null);
            if (DateTime.Now <= dateTime.AddMinutes(5))
            {
                var stream = await _streamingService.GetVideoUrl(URL);
                return new FileStreamResult(stream, "video/mp4");
            }
            else

            {

                var stream1 = await _streamingService.GetVideoUrl("");
                return new FileStreamResult(stream1, "video/mp4");
            }

            //var content = new FileStream("", FileMode.Open, FileAccess.Read, FileShare.Read);
            //var response = File(content, "application/octet-stream");
            //return response;
            //  return BadRequest();

        }

        [HttpGet("GetTocken")]
        public string GetTocken()
        {
            return CommonFunction.API_Key_Encrypt(DateTime.Now.ToString("ddMMyyyyHHmm"));
        }


        [HttpPost("SubmitEliteGetinTouch")]
        [EnableCors("AllowOrigin")]
        public string SubmitEliteGetinTouch(CorporateCarpoolModels models)
        {


            try
            {

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

                    return "Save";

                    //  return RedirectToAction("thanks", "Home");
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return "Some thing Wrong";
           

        }


    }
}