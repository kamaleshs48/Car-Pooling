using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GreenCabV1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenCabV1.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private IAzureVideoStreamService _streamingService;

        public VideoController(IAzureVideoStreamService streamingService)
        {
            _streamingService = streamingService;
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
    }
}